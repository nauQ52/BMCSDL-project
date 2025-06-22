--
-- QUAN LY CUA HANG TIEN LOI
--
DISCONNECT;

DROP USER DOAN CASCADE;

CREATE USER DOAN IDENTIFIED BY a1;
GRANT CREATE SESSION TO DOAN;
ALTER USER DOAN QUOTA 100M ON USERS;
GRANT CREATE TABLE TO DOAN;
GRANT EXECUTE ON DBMS_CRYPTO TO DOAN;
GRANT CREATE VIEW TO DOAN;
GRANT CREATE PROCEDURE TO DOAN;
GRANT CREATE TRIGGER TO DOAN;
GRANT CREATE USER TO DOAN;
GRANT CREATE SYNONYM TO DOAN;
/

SET SERVEROUTPUT ON
/

DROP TABLE SANPHAM CASCADE CONSTRAINTS;
DROP TABLE TAIKHOAN CASCADE CONSTRAINTS;
DROP TABLE THONGTINTK CASCADE CONSTRAINTS;
DROP TABLE HOADON CASCADE CONSTRAINTS;
DROP TABLE CHITIETHOADON CASCADE CONSTRAINTS;

TRUNCATE TABLE TAIKHOAN;
/

--
-- TABLE
--

-- Bang SANPHAM
CREATE TABLE SANPHAM (
  MASP VARCHAR2(128),
  TENSP NVARCHAR2(100) NOT NULL,
  DONGIA FLOAT DEFAULT 0 CHECK (DONGIA >= 0),
  SOLUONG INT DEFAULT 0 CHECK (SOLUONG >= 0),
  LOAISP NVARCHAR2(30) NOT NULL,
  CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP),
  CONSTRAINT UQ_SANPHAM UNIQUE (TENSP)
);
/

-- Bang TAIKHOAN
CREATE TABLE TAIKHOAN (
  MATK VARCHAR2(128),
  TENDANGNHAP CHAR(60) NOT NULL,
  LOAITK NVARCHAR2(20) NOT NULL CHECK (LOAITK IN ('Admin', 'User')),
  MATKQUANLY VARCHAR2(128),
  CONSTRAINT PK_TAIKHOAN PRIMARY KEY (MATK),
  CONSTRAINT UQ_TAIKHOAN UNIQUE (TENDANGNHAP),
  CONSTRAINT FK_TAIKHOAN_QUANLY FOREIGN KEY (MATKQUANLY) REFERENCES TAIKHOAN(MATK)
);
/

-- Bang THONGTINTK 
CREATE TABLE THONGTINTK (
  MATK VARCHAR2(128),
  TENTK NVARCHAR2(100) NOT NULL,
  SODIENTHOAI VARCHAR2(128) NOT NULL,
  DIACHI NVARCHAR2(500) NOT NULL,
  CONSTRAINT PK_THONGTINTK PRIMARY KEY (MATK),
  CONSTRAINT FK_TAIKHOAN_THONGTIN FOREIGN KEY (MATK) REFERENCES TAIKHOAN(MATK)
);
/

-- Bang HOADON
CREATE TABLE HOADON (
  MAHD VARCHAR2(128),
  TONGTIEN FLOAT NOT NULL CHECK (TONGTIEN >= 0),
  MATK VARCHAR2(128) NOT NULL,
  CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
  CONSTRAINT FK_TAIKHOAN FOREIGN KEY (MATK) REFERENCES TAIKHOAN(MATK)
);
/

-- Bang CHITIETHOADON
CREATE TABLE CHITIETHOADON (
  MASP VARCHAR2(128),
  MAHD VARCHAR2(128),
  TONGMUA INT NOT NULL CHECK (TONGMUA > 0),
  CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MASP, MAHD),
  CONSTRAINT FK_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
  CONSTRAINT FK_HOADON FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)
);
/

--
-- PROCEDURE
--

-- PROC DANG KI USER CHO USER SYS
CREATE OR REPLACE PROCEDURE SP_CREATEUSER
(username IN VARCHAR2,
pass IN VARCHAR2) 
IS
BEGIN
    EXECUTE IMMEDIATE 'CREATE USER ' || username || ' IDENTIFIED BY ' || pass;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || username;
END;
/

-- PROC DANG XUAT USER 
CREATE OR REPLACE PROCEDURE SP_LOGOUTUSER
(v_username in VARCHAR2)
IS
BEGIN
    FOR rec IN (SELECT SID, SERIAL# FROM V$SESSION WHERE USERNAME = v_username)
    LOOP 
        EXECUTE IMMEDIATE 'ALTER SYSTEM KILL SESSION "' || rec.SID || ',' || rec.SERIAL# || '" IMMEDIATE';
    END LOOP;
END;

EXEC SP_LOGOUTUSER('DOAN');
/

-- PROC RANDOM NONCE
CREATE OR REPLACE PROCEDURE SP_RANDOMNONCE(            
    nonce OUT VARCHAR2           
)
IS  
    v_random NUMBER(5);           
BEGIN
    v_random := TRUNC(DBMS_RANDOM.VALUE(10000, 99999));

    nonce := TO_CHAR(v_random);
END;

CREATE OR REPLACE SYNONYM SY_RANDOMNONCE FOR DOAN.SP_RANDOMNONCE;

DECLARE
    v_var VARCHAR2(5);
BEGIN
    SP_RANDOMNONCE(v_var);
    DBMS_OUTPUT.PUT_LINE(v_var);
END;
/

-- PROC XÁC THỰC CHALLENGE - RESPONSE
CREATE OR REPLACE PROCEDURE SP_AUTHCHALLENGERES (
    v_Mes IN VARCHAR2,
    v_Nonce IN VARCHAR2,
    v_pass IN VARCHAR2,
    flag OUT NUMBER
)
IS
    v_check VARCHAR2(50);
BEGIN
    v_check := v_pass || v_Nonce;
    v_check := RAWTOHEX(F_MD5_HASH(v_check));
    IF v_Mes = v_check THEN 
        flag := 1;
      ELSE 
        flag := 0;
    END IF;
END;
    

-- PROC MA HOA CAESAR
CREATE OR REPLACE PROCEDURE SP_encryptCaesarCipher(
    str IN VARCHAR2,          
    k IN NUMBER,              
    kq OUT VARCHAR2           
)
AS
    plainText VARCHAR2(32767);  
    len NUMBER;                 
    i NUMBER;                   
BEGIN
    plainText := UPPER(str);
    len := LENGTH(plainText);
    kq := '';

    FOR i IN 1..len LOOP
        kq := kq || F_shiftChar(substr(plainText, i, 1), k);
    END LOOP;
END;
/

-- PROC GIA MA CAESAR
CREATE OR REPLACE PROCEDURE SP_decryptCaesarCipher(
    str IN VARCHAR2,          
    k IN NUMBER,              
    kq OUT VARCHAR2           
)
AS
    plainText VARCHAR2(32767); 
    len NUMBER;                
BEGIN
    plainText := UPPER(str);   
    len := LENGTH(str);        

    kq := '';                 

    FOR i IN 1..len LOOP
        kq := kq || f_shiftChar(SUBSTR(plainText, i, 1), -k); 
    END LOOP;
END SP_decryptCaesarCipher;
/

-- PROC MA HOA NHAN
CREATE OR REPLACE PROCEDURE SP_encryptMultiCipher (
    input_str IN VARCHAR2, 
    k IN NUMBER, 
    output_str OUT VARCHAR2
)
AS
BEGIN
    output_str := F_encryptMultiCipher(input_str, k);
END;
/

-- PROC GIAI MA NHAN
CREATE OR REPLACE PROCEDURE SP_decryptMultiCipher (
    input_str IN VARCHAR2, 
    k IN NUMBER, 
    output_str OUT VARCHAR2
)
AS
BEGIN
    output_str := F_decryptMultiCipher(input_str, k);
END;
/

--
-- FUNCTION
--

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

-- HAM SHIFT CHAR DIV
CREATE OR REPLACE FUNCTION F_shiftCharDiv(c CHAR, key NUMBER) 
RETURN CHAR
IS
    t NUMBER := ASCII('A');
    ascii_val NUMBER;
    new_ascii NUMBER;
    k_inverse NUMBER;
    upper_char CHAR;
BEGIN
    IF NOT (c BETWEEN 'A' AND 'Z') AND NOT (c BETWEEN 'a' AND 'z') THEN
        RETURN c;
    END IF;
    k_inverse := mod_inverse(key);
    IF k_inverse IS NULL THEN
        RETURN c;
    END IF;
    upper_char := UPPER(c);
    ascii_val := ASCII(upper_char) - t;
    new_ascii := MOD(ascii_val * k_inverse, 26);
    RETURN CHR(new_ascii + t);
END shiftCharDiv_F;
/

-- HAM SHIFT CHAR MULTI
CREATE OR REPLACE FUNCTION F_shiftCharMul(c CHAR, k NUMBER) 
RETURN CHAR
IS
    t number (2);
BEGIN
    t := ASCII('A');
    if REGEXP_LIKE(c, '[a-z]|[A-Z]') then
        return (CHR(t + (ASCII (c) - t * k) MOD 26)); 
    else
        return NULL;
    end if;
END;
/

-- HAM UOC CHUNG
CREATE OR REPLACE FUNCTION F_GCD (
    a IN NUMBER,
    b IN NUMBER
)
RETURN NUMBER IS
    temp NUMBER;
    tempa NUMBER := a;
    tempb NUMBER := b;
BEGIN
    WHILE tempb != 0 LOOP
        temp := tempb;
        tempb := MOD(tempa, tempb);
        tempa := temp;
    END LOOP;
    RETURN tempa;
END;
/

--HAM TIM SO NGUYEN TO CUNG NHAU
CREATE OR REPLACE FUNCTION F_coprime(N IN NUMBER) RETURN NUMBER IS
    e NUMBER := 2;
BEGIN
    WHILE e < N LOOP
        IF F_GCD(e, N) = 1 THEN
            RETURN e;
        END IF;
        e := e + 1;
    END LOOP;
    RETURN 0;
END F_coprime;
/

--HAM NGHICH DAO
CREATE OR REPLACE FUNCTION F_modInverse(a IN NUMBER, m IN NUMBER) RETURN NUMBER IS
    m0 NUMBER := m;
    y NUMBER := 0;
    x NUMBER := 1;
    q NUMBER;
    temp_a NUMBER;
    temp_m NUMBER;
BEGIN
    IF m = 1 THEN
        RETURN 0;
    END IF;

    temp_a := a;
    temp_m := m;

    WHILE temp_a > 1 LOOP
        q := TRUNC(temp_a / temp_m);

        DECLARE
            t NUMBER;
        BEGIN
            t := temp_m;
            temp_m := MOD(temp_a, temp_m);
            temp_a := t;

            t := y;
            y := x - q * y;
            x := t;
        END;
    END LOOP;

    IF x < 0 THEN
        x := x + m0;
    END IF;

    RETURN x;
END;
/

--HAM TAO KHOA 
CREATE OR REPLACE FUNCTION F_pubpriKEY(p IN NUMBER, q IN NUMBER) RETURN SYS.ODCIVARCHAR2LIST IS
    N NUMBER;
    e NUMBER;
    d NUMBER;
    result SYS.ODCIVARCHAR2LIST := SYS.ODCIVARCHAR2LIST();
BEGIN
    IF p = q THEN
        RAISE_APPLICATION_ERROR(-20001, 'Cặp giá trị p và q không được bằng nhau.');
    END IF;

    N := p * q;
    e := F_coprime((p - 1) * (q - 1));

    IF e = 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'Không tìm thấy số nguyên tố cùng nhau với phi!');
    END IF;

    d := F_modInverse(e, (p - 1) * (q - 1));
    result.EXTEND(3);
    result(1) := e;
    result(2) := d;
    result(3) := N;
    RETURN result;
END;
/

--HAM MA HOA RSA
CREATE OR REPLACE FUNCTION F_encryptRSA(plaintext IN VARCHAR2, p IN NUMBER, q IN NUMBER) RETURN VARCHAR2 IS
    CHARACTER_LIST CONSTANT VARCHAR2(256) := 'ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789'; -- Định nghĩa danh sách ký tự
    charArray VARCHAR2(4000);
    stringArray VARCHAR2(4000) := '';
    keys SYS.ODCIVARCHAR2LIST;
BEGIN
    keys := F_pubpriKEY(p, q);
    charArray := UPPER(plaintext);

    FOR i IN 1 .. LENGTH(charArray) LOOP
        DECLARE
            charIndex NUMBER;
            value NUMBER;
            encrypted NUMBER;
            C VARCHAR2(3);
        BEGIN
            charIndex := INSTR(CHARACTER_LIST, SUBSTR(charArray, i, 1));
            IF charIndex > 0 THEN
                value := charIndex - 1;
                encrypted := MOD(POWER(value, TO_NUMBER(keys(1))), TO_NUMBER(keys(3)));
                C := LPAD(encrypted, 2, '0');
                stringArray := stringArray || C;
            END IF;
        END;
    END LOOP;
    RETURN stringArray;
END;
/

--HAM GIAI MA RSA
CREATE OR REPLACE FUNCTION F_decryptRSA(ciphertext IN VARCHAR2, p IN NUMBER, q IN NUMBER) RETURN VARCHAR2 IS
    CHARACTER_LIST CONSTANT VARCHAR2(256) := 'ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789'; -- Định nghĩa danh sách ký tự
    charArray VARCHAR2(4000);
    stringArray VARCHAR2(4000) := '';
    keys SYS.ODCIVARCHAR2LIST;
    decrypted VARCHAR2(4000);
    charIndex NUMBER;
BEGIN
    keys := F_pubpriKEY(p, q);
    charArray := UPPER(ciphertext);
    FOR i IN 1 .. LENGTH(charArray) LOOP
        DECLARE
            encrypted VARCHAR2(2);
            value NUMBER;
            C VARCHAR2(3);
        BEGIN
            encrypted := SUBSTR(charArray, i * 2 - 1, 2);
            value := TO_NUMBER(encrypted); 
            decrypted := TO_CHAR(MOD(POWER(value, TO_NUMBER(keys(2))), TO_NUMBER(keys(3)))); 
            IF decrypted < 0 OR decrypted > LENGTH(CHARACTER_LIST) - 1 THEN
                RAISE_APPLICATION_ERROR(-20004, 'Giá trị giải mã không hợp lệ: ' || decrypted);
            END IF;
            stringArray := stringArray || SUBSTR(CHARACTER_LIST, TO_NUMBER(decrypted) + 1, 1); -- Nối vào chuỗi kết quả
        END;
    END LOOP;

    RETURN stringArray;
END;
/

--HAM MA HOA TINH TRANG
CREATE OR REPLACE FUNCTION F_removeDiacritics(input_str VARCHAR2)
RETURN VARCHAR2
AS
    output_str VARCHAR2(4000);
BEGIN
    output_str := input_str;

    -- Chuyển đổi các ký tự có dấu thành không dấu
    output_str := REPLACE(output_str, 'á', 'a');
    output_str := REPLACE(output_str, 'à', 'a');
    output_str := REPLACE(output_str, 'ả', 'a');
    output_str := REPLACE(output_str, 'ã', 'a');
    output_str := REPLACE(output_str, 'ạ', 'a');
    output_str := REPLACE(output_str, 'ă', 'a');
    output_str := REPLACE(output_str, 'ắ', 'a');
    output_str := REPLACE(output_str, 'ằ', 'a');
    output_str := REPLACE(output_str, 'ẳ', 'a');
    output_str := REPLACE(output_str, 'ẵ', 'a');
    output_str := REPLACE(output_str, 'ặ', 'a');
    output_str := REPLACE(output_str, 'â', 'a');
    output_str := REPLACE(output_str, 'ấ', 'a');
    output_str := REPLACE(output_str, 'ầ', 'a');
    output_str := REPLACE(output_str, 'ẩ', 'a');
    output_str := REPLACE(output_str, 'ẫ', 'a');
    output_str := REPLACE(output_str, 'ậ', 'a');

    output_str := REPLACE(output_str, 'é', 'e');
    output_str := REPLACE(output_str, 'è', 'e');
    output_str := REPLACE(output_str, 'ẻ', 'e');
    output_str := REPLACE(output_str, 'ẽ', 'e');
    output_str := REPLACE(output_str, 'ẹ', 'e');
    output_str := REPLACE(output_str, 'ê', 'e');
    output_str := REPLACE(output_str, 'ế', 'e');
    output_str := REPLACE(output_str, 'ề', 'e');
    output_str := REPLACE(output_str, 'ể', 'e');
    output_str := REPLACE(output_str, 'ễ', 'e');
    output_str := REPLACE(output_str, 'ệ', 'e');

    output_str := REPLACE(output_str, 'í', 'i');
    output_str := REPLACE(output_str, 'ì', 'i');
    output_str := REPLACE(output_str, 'ỉ', 'i');
    output_str := REPLACE(output_str, 'ĩ', 'i');
    output_str := REPLACE(output_str, 'ị', 'i');

    output_str := REPLACE(output_str, 'ó', 'o');
    output_str := REPLACE(output_str, 'ò', 'o');
    output_str := REPLACE(output_str, 'ỏ', 'o');
    output_str := REPLACE(output_str, 'õ', 'o');
    output_str := REPLACE(output_str, 'ọ', 'o');
    output_str := REPLACE(output_str, 'ô', 'o');
    output_str := REPLACE(output_str, 'ố', 'o');
    output_str := REPLACE(output_str, 'ồ', 'o');
    output_str := REPLACE(output_str, 'ổ', 'o');
    output_str := REPLACE(output_str, 'ỗ', 'o');
    output_str := REPLACE(output_str, 'ộ', 'o');
    output_str := REPLACE(output_str, 'ơ', 'o');
    output_str := REPLACE(output_str, 'ớ', 'o');
    output_str := REPLACE(output_str, 'ờ', 'o');
    output_str := REPLACE(output_str, 'ở', 'o');
    output_str := REPLACE(output_str, 'ỡ', 'o');
    output_str := REPLACE(output_str, 'ợ', 'o');

    output_str := REPLACE(output_str, 'ú', 'u');
    output_str := REPLACE(output_str, 'ù', 'u');
    output_str := REPLACE(output_str, 'ủ', 'u');
    output_str := REPLACE(output_str, 'ũ', 'u');
    output_str := REPLACE(output_str, 'ụ', 'u');
    output_str := REPLACE(output_str, 'ư', 'u');
    output_str := REPLACE(output_str, 'ứ', 'u');
    output_str := REPLACE(output_str, 'ừ', 'u');
    output_str := REPLACE(output_str, 'ử', 'u');
    output_str := REPLACE(output_str, 'ữ', 'u');
    output_str := REPLACE(output_str, 'ự', 'u');

    output_str := REPLACE(output_str, 'ý', 'y');
    output_str := REPLACE(output_str, 'ỳ', 'y');
    output_str := REPLACE(output_str, 'ỷ', 'y');
    output_str := REPLACE(output_str, 'ỹ', 'y');
    output_str := REPLACE(output_str, 'ỵ', 'y');

    output_str := REPLACE(output_str, 'đ', 'd');

    -- Viết hoa cũng cần được thay thế
    output_str := REPLACE(output_str, 'Á', 'A');
    output_str := REPLACE(output_str, 'À', 'A');
    output_str := REPLACE(output_str, 'Ả', 'A');
    output_str := REPLACE(output_str, 'Ã', 'A');
    output_str := REPLACE(output_str, 'Ạ', 'A');
    output_str := REPLACE(output_str, 'Ă', 'A');
    output_str := REPLACE(output_str, 'Ắ', 'A');
    output_str := REPLACE(output_str, 'Ằ', 'A');
    output_str := REPLACE(output_str, 'Ẳ', 'A');
    output_str := REPLACE(output_str, 'Ẵ', 'A');
    output_str := REPLACE(output_str, 'Ặ', 'A');
    output_str := REPLACE(output_str, 'Â', 'A');
    output_str := REPLACE(output_str, 'Ấ', 'A');
    output_str := REPLACE(output_str, 'Ầ', 'A');
    output_str := REPLACE(output_str, 'Ẩ', 'A');
    output_str := REPLACE(output_str, 'Ẫ', 'A');
    output_str := REPLACE(output_str, 'Ậ', 'A');

    output_str := REPLACE(output_str, 'É', 'E');
    output_str := REPLACE(output_str, 'È', 'E');
    output_str := REPLACE(output_str, 'Ẻ', 'E');
    output_str := REPLACE(output_str, 'Ẽ', 'E');
    output_str := REPLACE(output_str, 'Ẹ', 'E');
    output_str := REPLACE(output_str, 'Ê', 'E');
    output_str := REPLACE(output_str, 'Ế', 'E');
    output_str := REPLACE(output_str, 'Ề', 'E');
    output_str := REPLACE(output_str, 'Ể', 'E');
    output_str := REPLACE(output_str, 'Ễ', 'E');
    output_str := REPLACE(output_str, 'Ệ', 'E');

    output_str := REPLACE(output_str, 'Í', 'I');
    output_str := REPLACE(output_str, 'Ì', 'I');
    output_str := REPLACE(output_str, 'Ỉ', 'I');
    output_str := REPLACE(output_str, 'Ĩ', 'I');
    output_str := REPLACE(output_str, 'Ị', 'I');

    output_str := REPLACE(output_str, 'Ó', 'O');
    output_str := REPLACE(output_str, 'Ò', 'O');
    output_str := REPLACE(output_str, 'Ỏ', 'O');
    output_str := REPLACE(output_str, 'Õ', 'O');
    output_str := REPLACE(output_str, 'Ọ', 'O');
    output_str := REPLACE(output_str, 'Ô', 'O');
    output_str := REPLACE(output_str, 'Ố', 'O');
    output_str := REPLACE(output_str, 'Ồ', 'O');
    output_str := REPLACE(output_str, 'Ổ', 'O');
    output_str := REPLACE(output_str, 'Ỗ', 'O');
    output_str := REPLACE(output_str, 'Ộ', 'O');
    output_str := REPLACE(output_str, 'Ơ', 'O');
    output_str := REPLACE(output_str, 'Ớ', 'O');
    output_str := REPLACE(output_str, 'Ờ', 'O');
    output_str := REPLACE(output_str, 'Ở', 'O');
    output_str := REPLACE(output_str, 'Ỡ', 'O');
    output_str := REPLACE(output_str, 'Ợ', 'O');

    output_str := REPLACE(output_str, 'Ú', 'U');
    output_str := REPLACE(output_str, 'Ù', 'U');
    output_str := REPLACE(output_str, 'Ủ', 'U');
    output_str := REPLACE(output_str, 'Ũ', 'U');
    output_str := REPLACE(output_str, 'Ụ', 'U');
    output_str := REPLACE(output_str, 'Ư', 'U');
    output_str := REPLACE(output_str, 'Ứ', 'U');
    output_str := REPLACE(output_str, 'Ừ', 'U');
    output_str := REPLACE(output_str, 'Ử', 'U');
    output_str := REPLACE(output_str, 'Ữ', 'U');
    output_str := REPLACE(output_str, 'Ự', 'U');

    output_str := REPLACE(output_str, 'Ý', 'Y');
    output_str := REPLACE(output_str, 'Ỳ', 'Y');
    output_str := REPLACE(output_str, 'Ỷ', 'Y');
    output_str := REPLACE(output_str, 'Ỹ', 'Y');
    output_str := REPLACE(output_str, 'Ỵ', 'Y');

    output_str := REPLACE(output_str, 'Đ', 'D');

    RETURN output_str;
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

--
-- TRIGGER
--

--RANG BUOC HASH MAT KHAU
CREATE OR REPLACE TRIGGER TRIGGER_INSERT_MaTKHAU
BEFORE INSERT ON TAIKHOAN
FOR EACH ROW
BEGIN
    :NEW.MatKhau := RAWTOHEX(F_MD5_HASH(:NEW.MatKhau));
END;
/

-- RANG BUOC MA HOA SDT BANG DES
CREATE OR REPLACE TRIGGER TRIGGER_INSERT_SODIENTHOAI
BEFORE INSERT ON TAIKHOAN
FOR EACH ROW
BEGIN
    :NEW.SODIENTHOAI := RAWTOHEX(F_encryptDES(:NEW.SODIENTHOAI));
END;
/

-- RANG BUOC MA HOA DIA CHI BANG AES
CREATE OR REPLACE TRIGGER TRIGGER_INSERT_DIACHI
BEFORE INSERT ON TAIKHOAN
FOR EACH ROW
BEGIN
    :NEW.DIACHI := RAWTOHEX(F_encryptAES(:NEW.DIACHI));
END;
/


-- Thêm dữ liệu vào bảng SANPHAM
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934841901856',N'Sữa tươi Cô Gái Hà Lan có đường hộp 180ml', 10000, 120, N'Sữa');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8935217400355',N'Sữa Tươi Tiệt Trùng Ít Đường TH true MILK 180 ml', 10000, 300, N'Sữa');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934614015025',N'Sữa đậu nành Fami Nguyên chất có đường hộp 200ml', 7000, 90, N'Sữa');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8936079120139',N'Snack Lays Vị Khoai Tây Tự Nhiên Classic Gói 90g', 22000, 100, N'Snack');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8936036029031',N'Snack Vị Tảo Biển Nori King Marine Boy Gói 60g', 12000, 90, N'Snack');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934588232114',N'Nước Tăng Lực Sting Vị Dâu Lon 320ml', 14000, 80, N'Nước uống');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934563193263',N'Mì Siu Kay Vị Hải Sản Acecook Gói 128G', 15000, 50, N'Mì');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8935001820062',N'Bút Xóa Thiên Long CP-02', 30000, 20, N'Văn phòng phẩm');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8935001808282',N'Bút Lông Dầu Thiên Long PM07 Mực Đỏ Vỉ 2 Cây', 28000, 20, N'Văn phòng phẩm');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8935049501534',N'Nước Ngọt Coca Cola Zero Lon 320ml', 11000, 60, N'Nước uống');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934563122201',N'Hảo Hảo Big Tôm Chua Cay Gói 100G', 7000, 50, N'Mì');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8935006360006',N'Bánh Mì Hoa Cúc Otto 300g', 50000, 15, N'Bánh mì');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8935001719106',N'Kẹo Cà Phê Sữa Maccofee Cà Phê Phố Gói 101.5G', 15000, 40, N'Kẹo');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934868152590',N'Dầu Gội Clear Bạc Hà Mát Lạnh Sạch Gàu Chai 880g', 250000, 20, N'Dầu gội - Sữa Tắm');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8938523699185',N'Cá Viên HT Food Gói 500g', 42000, 7, N'Thực phẩm đông lạnh');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8934717401909',N'Mandu kim chi và gà CJ 350G', 60000, 8, N'Thực phẩm đông lạnh');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8936036028379',N'Bánh Mì Baguette Cest Bon Vị Bơ Tỏi Đút Lò Gói 180G', 36000, 7, N'Bánh mì');
INSERT INTO SANPHAM (MASP, TENSP, DONGIA, SOLUONG, LOAISP) 
VALUES ('8859578600257',N'Kẹo Playmore Dưa Hấu 22G', 38000, 20, N'Kẹo');
/

SELECT * FROM SANPHAM;
/

-- Thêm dữ liệu vào bảng TAIKHOAN
INSERT INTO TAIKHOAN (MATK, TENDANGNHAP, LOAITK, MATKQUANLY) 
VALUES ('TK000', 'DOAN', N'Admin', NULL); 
INSERT INTO TAIKHOAN (MATK, TENDANGNHAP, LOAITK, MATKQUANLY) 
VALUES ('TK001', 'quangnv', N'Admin', NULL); 
INSERT INTO TAIKHOAN (MATK, TENDANGNHAP, LOAITK, MATKQUANLY) 
VALUES ('TK002', 'tutt', N'Admin', NULL); 
INSERT INTO TAIKHOAN (MATK, TENDANGNHAP, LOAITK, MATKQUANLY) 
VALUES ('TK003', 'longlh', N'User', 'TK001'); 
INSERT INTO TAIKHOAN (MATK, TENDANGNHAP, LOAITK, MATKQUANLY) 
VALUES ('TK004', 'anhpm', N'User', 'TK002'); 
INSERT INTO TAIKHOAN (MATK, TENDANGNHAP, LOAITK, MATKQUANLY) 
VALUES ('TK005', 'ngocvt', N'User', 'TK001'); 
/

SELECT * FROM TAIKHOAN;
/

-- Thêm dữ liệu vào bảng THONGTINTK
INSERT INTO THONGTINTK (MATK, TENTK , SODIENTHOAI, DIACHI) 
VALUES ('TK000', N'Quản Lý Cửa Hàng Tiện Lợi', '0000000000', N'XXXXXXXXXX'); 
INSERT INTO THONGTINTK (MATK, TENTK , SODIENTHOAI, DIACHI) 
VALUES ('TK001', N'Nguyễn Văn Quang', '0912345678', N'123 Lê Lợi, Quận 1, TP.HCM'); 
INSERT INTO THONGTINTK (MATK, TENTK , SODIENTHOAI, DIACHI) 
VALUES ('TK002', N'Trần Thị Tú', '0918765432', N'45 Nguyễn Huệ, Quận 1, TP.HCM'); 
INSERT INTO THONGTINTK (MATK, TENTK , SODIENTHOAI, DIACHI) 
VALUES ('TK003', N'Nguyễn Văn Quang', '0912345678', N'123 Lê Lợi, Quận 1, TP.HCM'); 
INSERT INTO THONGTINTK (MATK, TENTK , SODIENTHOAI, DIACHI) 
VALUES ('TK004', N'Phạm Minh Anh', '0908765432', N'78 Lý Tự Trọng, Quận 1, TP.HCM'); 
INSERT INTO THONGTINTK (MATK, TENTK , SODIENTHOAI, DIACHI) 
VALUES ('TK005', N'Võ Thị Ngọc', '0932345678', N'100 Nguyễn Văn Trỗi, Quận Phú Nhuận, TP.HCM'); 
/

SELECT * FROM THONGTINTK;
/

TRUNCATE TABLE TAIKHOAN; --XOA DU LIEU
/

-- Thêm dữ liệu vào bảng HOADON
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD001', 1200000, 'TK001');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD002', 1500000, 'TK002');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD003', 1700000, 'TK003');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD004', 900000, 'TK004');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD005', 1100000, 'TK005');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD006', 800000, 'TK001');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD007', 1250000, 'TK002');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD008', 1350000, 'TK003');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD009', 950000, 'TK004');
INSERT INTO HOADON (MAHD, TONGTIEN, MATK) 
VALUES ('HD010', 1400000, 'TK005');
/

SELECT * FROM HOADON;
/

-- Thêm dữ liệu vào bảng CHITIETHOADON
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934841901856', 'HD001', 10);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935217400355', 'HD001', 20);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934614015025', 'HD002', 15);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8936079120139', 'HD002', 25);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8936036029031', 'HD003', 10);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934588232114', 'HD003', 30);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934563193263', 'HD004', 10);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935001820062', 'HD004', 8);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935001808282', 'HD005', 15);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935049501534', 'HD005', 7);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934563122201', 'HD006', 12);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935006360006', 'HD006', 18);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935001719106', 'HD007', 7);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934868152590', 'HD007', 4);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8938523699185', 'HD008', 6);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934717401909', 'HD008', 10);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8936036028379', 'HD009', 5);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8859578600257', 'HD009', 15);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8934841901856', 'HD010', 12);
INSERT INTO CHITIETHOADON (MASP, MAHD, TONGMUA) 
VALUES ('8935217400355', 'HD010', 8);
/

SELECT * FROM CHITIETHOADON;
/
