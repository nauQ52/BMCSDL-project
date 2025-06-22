--
-- QUAN LY CUA HANG TIEN LOI
--

--
-- PACKAGE
--

--PACKAGE CAESAR
CREATE OR REPLACE PACKAGE CaesarCipher
AS
    FUNCTION encrypt (p_plaintext VARCHAR2, k NUMBER) RETURN VARCHAR2 DETERMINISTIC;
    FUNCTION decrypt (p_encryptedText VARCHAR2, k NUMBER) RETURN VARCHAR2 DETERMINISTIC;
    FUNCTION shift_char (c CHAR, k NUMBER) RETURN CHAR DETERMINISTIC;
END CaesarCipher;
/
CREATE OR REPLACE PACKAGE BODY CaesarCipher AS

    FUNCTION shift_char (c CHAR, k NUMBER) RETURN CHAR DETERMINISTIC IS
        base NUMBER(2);
    BEGIN
        IF REGEXP_LIKE(c, '[A-Z]') THEN
            base := ASCII('A');
            RETURN CHR(base + MOD(ASCII(c) - base + k, 26));
        ELSIF REGEXP_LIKE(c, '[a-z]') THEN
            base := ASCII('a');
            RETURN CHR(base + MOD(ASCII(c) - base + k, 26));
        ELSE
            RETURN c;
        END IF;
    END shift_char;

    FUNCTION encrypt (p_plaintext VARCHAR2, k NUMBER) RETURN VARCHAR2 DETERMINISTIC AS
        i NUMBER(2);
        len NUMBER(5);
        kq VARCHAR2(100) := '';
        adjusted_k NUMBER;
    BEGIN
        len := LENGTH(p_plaintext);
        adjusted_k := MOD(k, 26);

        FOR i IN 1..len LOOP
            kq := kq || shift_char(SUBSTR(p_plaintext, i, 1), adjusted_k);
        END LOOP;
        RETURN kq;
    END encrypt;

    FUNCTION decrypt (p_encryptedText VARCHAR2, k NUMBER) RETURN VARCHAR2 DETERMINISTIC AS
    BEGIN
        RETURN encrypt(p_encryptedText, 26 - MOD(k, 26));
    END decrypt;

END CaesarCipher;
/
SET SERVEROUTPUT ON;

DECLARE 
    plainText VARCHAR2(200) := 'Hello World';
    cipherText VARCHAR2(200);
BEGIN 
    cipherText := CaesarCipher.encrypt(plainText, 3);
    DBMS_OUTPUT.PUT_LINE('ENCRYPTED: ' || cipherText);
    DBMS_OUTPUT.PUT_LINE('DECRYPTED: ' || CaesarCipher.decrypt(cipherText, 3));
END;
/
--PACKAGE MULTIENCRYPTION
CREATE OR REPLACE PACKAGE MultiEncryption AS 
    FUNCTION encrypt (input_str VARCHAR2, k NUMBER) RETURN VARCHAR2 DETERMINISTIC;
    FUNCTION decrypt (input_str VARCHAR2, k NUMBER) RETURN VARCHAR2 DETERMINISTIC;
END MultiEncryption;
/
CREATE OR REPLACE PACKAGE BODY MultiEncryption AS

    FUNCTION mod_inverse(key NUMBER) RETURN NUMBER IS
        k NUMBER := key;
        m NUMBER := 26;
        x0 NUMBER := 0;
        x1 NUMBER := 1;
        q NUMBER;
        t NUMBER;
    BEGIN
        IF k <= 0 OR k >= m THEN
            RETURN NULL;
        END IF;
        WHILE k > 1 LOOP
            q := FLOOR(k / m);
            t := m;
            m := MOD(k, m);
            k := t;
            t := x0;
            x0 := x1 - q * x0;
            x1 := t;
        END LOOP;
        IF x1 < 0 THEN
            x1 := x1 + 26;
        END IF;

        RETURN x1;
    END mod_inverse;

    FUNCTION shiftCharMul(c CHAR, k NUMBER) RETURN CHAR IS
        t NUMBER;
        ascii_val NUMBER;
        new_ascii NUMBER;
    BEGIN
        IF REGEXP_LIKE(c, '[A-Z]') THEN
            t := ASCII('A');
        ELSIF REGEXP_LIKE(c, '[a-z]') THEN
            t := ASCII('a');
        ELSE
            RETURN c;
        END IF;

        ascii_val := ASCII(c) - t;
        new_ascii := MOD(ascii_val * k, 26);
        RETURN CHR(new_ascii + t);
    END shiftCharMul;

    FUNCTION encrypt(input_str VARCHAR2, k NUMBER) RETURN VARCHAR2 IS
        i NUMBER;
        len NUMBER;
        kq VARCHAR2(100) := '';
    BEGIN
        len := LENGTH(input_str);
        
        FOR i IN 1..len LOOP
            kq := kq || shiftCharMul(SUBSTR(input_str, i, 1), k);
        END LOOP;
        
        RETURN kq;
    END encrypt;

    FUNCTION shiftCharDiv(c CHAR, key NUMBER) RETURN CHAR IS
        t NUMBER;
        ascii_val NUMBER;
        new_ascii NUMBER;
        k_inverse NUMBER;
        upper_char CHAR;
    BEGIN
        IF REGEXP_LIKE(c, '[A-Z]') THEN
            t := ASCII('A');
        ELSIF REGEXP_LIKE(c, '[a-z]') THEN
            t := ASCII('a');
        ELSE
            RETURN c;
        END IF;

        k_inverse := mod_inverse(key);
        IF k_inverse IS NULL THEN
            RETURN c;
        END IF;

        ascii_val := ASCII(c) - t;
        new_ascii := MOD(ascii_val * k_inverse, 26);
        RETURN CHR(new_ascii + t);
    END shiftCharDiv;

    FUNCTION decrypt(input_str VARCHAR2, k NUMBER) RETURN VARCHAR2 IS
        i NUMBER;
        len NUMBER;
        kq VARCHAR2(100) := '';
    BEGIN
        len := LENGTH(input_str);
        
        FOR i IN 1..len LOOP
            kq := kq || shiftCharDiv(SUBSTR(input_str, i, 1), k);
        END LOOP;
        RETURN kq;
    END decrypt;

END MultiEncryption;
/
SET SERVEROUTPUT ON;

DECLARE 
    plainText VARCHAR2(200) := 'Hello World';
    encryptedText VARCHAR2(200);
    decryptedText VARCHAR2(200);
    key NUMBER := 7;
BEGIN 
    encryptedText := MultiEncryption.encrypt(plainText, key);
    DBMS_OUTPUT.PUT_LINE('ENCRYPTED: ' || encryptedText);
    decryptedText := MultiEncryption.decrypt(encryptedText, key);
    DBMS_OUTPUT.PUT_LINE('DECRYPTED: ' || decryptedText);
END;
/
--PACKAGE DES
CREATE OR REPLACE PACKAGE DES AS 
    FUNCTION encrypt (p_plainText VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC;
    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC;
END;
/
CREATE OR REPLACE PACKAGE BODY DES AS 
    encryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_DES 
                                  + DBMS_CRYPTO.CHAIN_CBC 
                                  + DBMS_CRYPTO.PAD_PKCS5;

    FUNCTION encrypt (p_plainText VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC 
    IS
        encryption_key RAW(32) := UTL_RAW.cast_to_raw(priKey);
        encrypted_raw RAW(2000);
    BEGIN
        encrypted_raw := DBMS_CRYPTO.ENCRYPT
        (
            src => UTL_RAW.cast_to_raw(p_plainText),
            typ => encryption_type,
            key => encryption_key
        );
        RETURN encrypted_raw;
    END encrypt;
    
    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC 
    IS
        encryption_key RAW(32) := UTL_RAW.cast_to_raw(priKey);
        decrypted_raw RAW(2000);
    BEGIN
        decrypted_raw := DBMS_CRYPTO.DECRYPT
        (
            src => p_encryptedText,
            typ => encryption_type,
            key => encryption_key
        );
        RETURN (UTL_RAW.CAST_TO_VARCHAR2(decrypted_raw));
    END decrypt;
END;
/
set serveroutput on;

declare 
    plainText NVARCHAR2(200):='Hello World';
    cipherText raw(2000);
begin 
    cipherText :=DES.encrypt(plainText,'PRIVATEKEY');
    DBMS_OUTPUT.PUT_LINE('ENCRYPTED: '|| cipherText);
    DBMS_OUTPUT.PUT_LINE('DECRYPTED: '|| DES.decrypt(cipherText,'PRIVATEKEY'));
END;

drop package DES;
drop package body DES;
/
-- PACKAGE TRIPLEDES
CREATE OR REPLACE PACKAGE TripDES
AS
    FUNCTION encrypt (p_plaintext VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC;
    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC;
END TripDES;
/
CREATE OR REPLACE PACKAGE BODY TripDES
AS
    encryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_3DES
                                + DBMS_CRYPTO.CHAIN_CBC
                                + DBMS_CRYPTO.PAD_PKCS5;
                                
    FUNCTION encrypt (p_plaintext VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC
    IS
        encryption_key RAW(32) := UTL_RAW.CAST_TO_RAW(priKey);
        encrypted_raw RAW(32767);
    BEGIN
        encrypted_raw := DBMS_CRYPTO.ENCRYPT(
            src => UTL_RAW.CAST_TO_RAW(p_plaintext),
            typ => encryption_type,
            key => encryption_key
        );
        RETURN encrypted_raw;
    END encrypt;
    
    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC
    IS
        encryption_key RAW(32) := UTL_RAW.CAST_TO_RAW(priKey);
        decrypted_raw RAW(32767);
    BEGIN
        decrypted_raw := DBMS_CRYPTO.DECRYPT(
            src => p_encryptedText,
            typ => encryption_type,
            key => encryption_key
        );
        RETURN UTL_RAW.CAST_TO_VARCHAR2(decrypted_raw);
    END decrypt;
END TripDES;

/
SET SERVEROUTPUT ON;

DECLARE 
    plainText VARCHAR2(200) := 'Hello World';
    cipherText RAW(32767);
    decryptedText VARCHAR2(200);
BEGIN 
    cipherText := TripDES.encrypt(plainText, '123456789012345678901234');
    DBMS_OUTPUT.PUT_LINE('ENCRYPTED: ' || RAWTOHEX(cipherText));
    decryptedText := TripDES.decrypt(cipherText, '123456789012345678901234');
    DBMS_OUTPUT.PUT_LINE('DECRYPTED: ' || decryptedText);
END;
/

--
-- Package RSA
CREATE OR REPLACE PACKAGE CRYPTO_PKG AS
    FUNCTION GET_PUBLIC_KEY RETURN VARCHAR2;
    FUNCTION GET_PRIVATE_KEY RETURN VARCHAR2;

    FUNCTION ENCRYPT_DATA(p_data IN VARCHAR2) RETURN VARCHAR2;
    FUNCTION DECRYPT_DATA(p_encrypted_data IN VARCHAR2) RETURN VARCHAR2;
END CRYPTO_PKG;
/
CREATE OR REPLACE PACKAGE BODY CRYPTO_PKG AS
    -- Biến để lưu trữ public và private key
    v_public_key  VARCHAR2(4000);
    v_private_key VARCHAR2(4000);

    FUNCTION GET_PUBLIC_KEY RETURN VARCHAR2 IS
    BEGIN
        IF v_public_key IS NULL THEN
            SELECT REGEXP_SUBSTR(RSA_KEYS, 'publicKey start****(.+?)****publicKey end', 1, 1, NULL, 1)
            INTO v_public_key
            FROM (SELECT CRYPTO.RSA_GENERATE_KEYS(1024) AS RSA_KEYS FROM DUAL);
        END IF;
        RETURN v_public_key;
    END GET_PUBLIC_KEY;

    FUNCTION GET_PRIVATE_KEY RETURN VARCHAR2 IS
    BEGIN
        IF v_private_key IS NULL THEN
            SELECT REGEXP_SUBSTR(RSA_KEYS, 'privateKey start****(.+?)****privateKey end', 1, 1, NULL, 1)
            INTO v_private_key
            FROM (SELECT CRYPTO.RSA_GENERATE_KEYS(1024) AS RSA_KEYS FROM DUAL);
        END IF;
        RETURN v_private_key;
    END GET_PRIVATE_KEY;

    FUNCTION ENCRYPT_DATA(p_data IN VARCHAR2) RETURN VARCHAR2 IS
    BEGIN
        RETURN CRYPTO.RSA_ENCRYPT(p_data, GET_PUBLIC_KEY());
    END ENCRYPT_DATA;

    FUNCTION DECRYPT_DATA(p_encrypted_data IN VARCHAR2) RETURN VARCHAR2 IS
    BEGIN
        RETURN CRYPTO.RSA_DECRYPT(p_encrypted_data, GET_PRIVATE_KEY());
    END DECRYPT_DATA;

END CRYPTO_PKG;
/
SET SERVEROUTPUT ON;

SELECT CRYPTO_PKG.ENCRYPT_DATA('This is my secret message.') FROM DUAL;
SELECT CRYPTO_PKG.DECRYPT_DATA('cypherText') FROM DUAL;
