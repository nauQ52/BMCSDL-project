--
-- QUAN LY CUA HANG TIEN LOI
--

--
-- FUNCTION
--

--ST
create or replace FUNCTION F_ACCOUNT_STATUS (user in varchar2)
RETURN varchar2
IS
    t varchar2(50);
BEGIN
    SELECT account_status INTO t FROM V_USERS WHERE username = user;
    RETURN t;
EXCEPTION WHEN OTHERS THEN t := ' ';
    RETURN t;
END;
/
-- HAM SHIFTCHAR
CREATE OR REPLACE FUNCTION F_shiftChar(c char, k number) 
RETURN CHAR
IS
    t number (2);
BEGIN
    t := ASCII('A');
    if REGEXP_LIKE(c, '[a-z]|[A-Z]') then
        return (CHR(t + (ASCII (c) - t+k) MOD 26)); 
    else
        return NULL;
    end if;
END;
/

-- HAM MA HOA CAESAR
CREATE OR REPLACE FUNCTION F_encryptCaesarCipher (str varchar, k number)
RETURN VARCHAR
AS
    i number (2);
    len number(5);
    kq varchar(100) :='';
    plainText varchar(250);
BEGIN
    plainText := upper(str);
    len:= length(str);
    FOR i in 1..len LOOP
        kq:=kq || F_shiftChar (substr(plainText, i, 1), k);
    END LOOP;
    RETURN kq;
END;
/

-- HAM GIAI MA CAESAR
CREATE OR REPLACE FUNCTION F_decryptCaesarCipher (str varchar, k number) 
RETURN VARCHAR
AS
BEGIN
    RETURN F_encryptCaesarCipher (str, 26-k);
END;
/

-- HAM MA HOA PHEP NHAN
CREATE OR REPLACE FUNCTION F_shiftCharMul (input_char VARCHAR2, k NUMBER) 
RETURN VARCHAR2
IS
    shifted_char VARCHAR2(1);
    ascii_val NUMBER;
BEGIN
    -- Chuyển ký tự thành mã ASCII, nhân với k, và chuyển lại thành ký tự
    ascii_val := ASCII(input_char) * k;
    shifted_char := CHR(MOD(ascii_val, 256)); -- Đảm bảo kết quả nằm trong khoảng hợp lệ
    RETURN shifted_char;
END;
/

CREATE OR REPLACE FUNCTION F_encryptMultiCipher (input_str VARCHAR2, k NUMBER) 
RETURN VARCHAR2
AS
    i NUMBER;
    len NUMBER;
    kq VARCHAR2(100) := '';
BEGIN
    len := LENGTH(input_str);

    FOR i IN 1..len LOOP
        kq := kq || F_shiftCharMul(substr(input_str, i, 1), k);
    END LOOP;

    RETURN kq;
END;
/

-- HAM GIAI MA PHEP NHAN
CREATE OR REPLACE FUNCTION F_decryptMultiCipher(input_str VARCHAR2, k NUMBER) 
RETURN VARCHAR2
AS
    i NUMBER;
    len NUMBER;
    kq VARCHAR2(100) := ''; 
BEGIN
    len := LENGTH(input_str);

    FOR i IN 1..len LOOP
        kq := kq || F_shiftCharMul(SUBSTR(input_str, i, 1), k);
    END LOOP;

    RETURN kq;
END;
/

-- HAM MA HOA DES 
CREATE OR REPLACE FUNCTION F_encryptDES (
    p_plaintext char
) return raw is
    i_key raw(8) := utl_raw.cast_to_raw('mAhoAdEs'); 
    i_encrypted raw(2000);
begin
    i_encrypted := dbms_crypto.encrypt(
        src => utl_raw.cast_to_raw(p_plaintext), 
        typ => dbms_crypto.des_cbc_pkcs5,      
        key => i_key
    );
    return i_encrypted;
END;
/

-- HAM GIAI MA DES
CREATE OR REPLACE FUNCTION F_decryptDES (
    p_encrypted RAW
) RETURN VARCHAR2 IS
    i_key RAW(8) := utl_raw.cast_to_raw('mAhoAdEs');
    i_decrypted RAW(2000);
BEGIN
    i_decrypted := DBMS_CRYPTO.DECRYPT(
        src => p_encrypted,
        typ => DBMS_CRYPTO.DES_CBC_PKCS5,
        key => i_key
    );
    RETURN UTL_RAW.cast_to_varchar2(i_decrypted);
END;
/

-- HAM MA HOA AES
CREATE OR REPLACE FUNCTION F_encryptAES (
    p_plaintext CHAR
) RETURN RAW IS
    l_key RAW(16) := UTL_RAW.cast_to_raw('MahOaAeS12345678'); 
    l_encrypted RAW(2000);
BEGIN
    l_encrypted := DBMS_CRYPTO.ENCRYPT(
        src => UTL_RAW.cast_to_raw(p_plaintext), 
        typ => DBMS_CRYPTO.AES_CBC_PKCS5,   
        key => l_key
    );
    RETURN l_encrypted;
END;
/

-- HAM GIAI MA AES
CREATE OR REPLACE FUNCTION F_decryptAES (
    p_encrypted RAW
) RETURN VARCHAR2 IS
    l_key RAW(16) := UTL_RAW.cast_to_raw('MahOaAeS12345678'); 
    l_decrypted RAW(2000);
BEGIN
    l_decrypted := DBMS_CRYPTO.DECRYPT(
        src => p_encrypted,
        typ => DBMS_CRYPTO.AES_CBC_PKCS5,
        key => l_key
    );
    RETURN UTL_RAW.cast_to_varchar2(l_decrypted);
END;
/

-- HAM BAM HASH MD5
CREATE OR REPLACE FUNCTION F_MD5_HASH(p_input IN VARCHAR2) RETURN RAW IS
    l_raw RAW(16);
BEGIN
    l_raw := DBMS_CRYPTO.HASH(UTL_RAW.CAST_TO_RAW(p_input), DBMS_CRYPTO.HASH_MD5);
    RETURN l_raw;
END;
/