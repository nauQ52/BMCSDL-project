--
-- QUAN LY CUA HANG TIEN LOI
--

--
-- 5.
--
--5.1
-- Tao user ols_test
CREATE USER ols_test IDENTIFIED BY 123
DEFAULT TABLESPACE users
TEMPORARY TABLESPACE temp
QUOTA UNLIMITED ON users;

--gan quyen de user truy cap vao he thong bang sys
GRANT connect TO ols_test;
GRANT CREATE TABLE TO ols_test;
GRANT select any TABLE TO ols_test;
GRANT update any TABLE TO ols_test;
GRANT delete any TABLE TO ols_test;

GRANT execute ON to_lbac_data_label To ols_test WITH GRANT OPTION;
GRANT execute ON SA_SYSDBA TO ols_test;


--Package dùng de tao ra các thành phan cua nhãn
GRANT execute ON sa_components To ols_test;
--Package dùng de tao các nhãn
GRANT execute ON sa_label_admin To ols_test;
--Package dùng de gán chính sách cho các table/schema
GRANT execute ON sa_policy_admin To ols_test;
--Package dùng de gán các label cho user
GRANT execute ON sa_user_admin To ols_test;

--5.2 tao chinh sach
--dung user lbacsys de tao chinh sach
    BEGIN
    SA_SYSDBA.CREATE_POLICY (
    policy_name => 'region_policy',
    column_name => 'region_label');
    END;
/
--user gán quyen cho user lbacsys
GRANT SELECT ON DBA_USERS TO LBACSYS;
--thu tuc select tat ca user
create or replace procedure pro_select_all_users
(v_out out sys_refcursor)
is
    begin
    open v_out for
        SELECT username
        FROM dba_users
        ORDER BY username ASC;
end;
/
--user lbacsys gan quyen de user ols test quan ly chinh sach nay
GRANT region_policy_DBA TO ols_test;
--thu tuc tao chinh sach OLS
create or replace procedure pro_create_policy
(policyName in VARCHAR2, colName in VARCHAR2)
is
begin
    SA_SYSDBA. CREATE_POLICY (
    policy_name => policyName,
    column_name => colName);
end;
/
--thuc tuc gan quyen den 1 user quan ly 1 chinh sach
CREATE OR REPLACE PROCEDURE pro_grant_policy(
    policyName IN VARCHAR2,
    username IN VARCHAR2
)
IS
    text VARCHAR2(200);
BEGIN
    text := 'GRANT ' || policyName || ' DBA TO ' || username;
    EXECUTE IMMEDIATE text;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE pro_create_policy(
    policyName IN VARCHAR2,
    colName IN VARCHAR2
)
IS
BEGIN
    SA_SYSDBA.CREATE_POLICY(
        policy_name => policyName,
        column_name => colName
    );
END;
/


--thu tuc select tat ca policy ols hien co
CREATE OR REPLACE PROCEDURE pro_select_OLS_POLICIES(
    v_out OUT SYS_REFCURSOR
)
IS
BEGIN
    OPEN v_out FOR
        SELECT POLICY_NAME FROM ALL_SA_POLICIES;
END;
/

--5.3 thu tuc DISABLE POLICY    
CREATE OR REPLACE PROCEDURE pro_disable_policy(
    policyName IN VARCHAR2
)
IS
BEGIN
    SA_SYSDBA.DISABLE_POLICY(
        policy_name => policyName
    );
END;
/
--thu tuc ENABLE POLICY    
CREATE OR REPLACE PROCEDURE pro_enable_policy(
    policyName IN VARCHAR2
)
IS
BEGIN
    SA_SYSDBA.ENABLE_POLICY(
        policy_name => policyName
    );
END;
/
--thu tuc select tat ca policy ols hien co
CREATE OR REPLACE PROCEDURE pro_select_OLS_POLICIES (
    v_out OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN v_out FOR
    SELECT * FROM ALL_SA_POLICIES;
END;
/
--thu tuc select status 1 policy ols hien co
CREATE OR REPLACE PROCEDURE pro_select_Status_OLS_POLICIES (
    policyName IN VARCHAR2,
    v_out OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN v_out FOR
    SELECT status
    FROM ALL_SA_POLICIES
    WHERE POLICY_NAME = policyName;
END;
/
--tao packet cho chuc nang disable va enable policy OLS
CREATE OR REPLACE PACKAGE packg_disable_enable_policy IS
    PROCEDURE pro_disable_policy (policyName IN VARCHAR2);
    PROCEDURE pro_enable_policy (policyName IN VARCHAR2);
    PROCEDURE pro_select_OLS_POLICIES (v_out OUT SYS_REFCURSOR);
    PROCEDURE pro_select_Status_OLS_POLICIES (policyName IN VARCHAR2, v_out OUT SYS_REFCURSOR);
END packg_disable_enable_policy;
/
CREATE OR REPLACE PACKAGE BODY packg_disable_enable_policy IS

    PROCEDURE pro_disable_policy (policyName IN VARCHAR2) IS
    BEGIN
        sa_sysdba.disable_policy(
            policy_name => policyName);
    END pro_disable_policy;

    PROCEDURE pro_enable_policy (policyName IN VARCHAR2) IS
    BEGIN
        sa_sysdba.enable_policy(
            policy_name => policyName);
    END pro_enable_policy;

    PROCEDURE pro_select_OLS_POLICIES (v_out OUT SYS_REFCURSOR) IS
    BEGIN
        OPEN v_out FOR
        SELECT * FROM ALL_SA_POLICIES;
    END pro_select_OLS_POLICIES;

    PROCEDURE pro_select_Status_OLS_POLICIES (
        policyName IN VARCHAR2,
        v_out OUT SYS_REFCURSOR
    ) IS
    BEGIN
        OPEN v_out FOR
        SELECT status
        FROM ALL_SA_POLICIES
        WHERE POLICY_NAME = policyName;
    END pro_select_Status_OLS_POLICIES;

END packg_disable_enable_policy;
/









