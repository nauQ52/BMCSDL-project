create or replace package PHANQUYEN
as
    --1
    procedure SP_SELECT_PROCEDURE_USER(useowner in varchar2, pro_type in varchar2, cur out sys_refcursor);

    --2
    procedure SP_SELECT_USER(cur out sys_refcursor);

    --3
    procedure SP_SELECT_ROLES(cur out sys_refcursor);

    --4
    procedure SP_USER_ROLES(username in varchar2, cur out sys_refcursor);

    --5
    procedure SP_USER_ROLES_CHECK(username in varchar2, roles in varchar2, cout out number);

    --6
    procedure SP_SELECT_TABLE(username in varchar2, cur out sys_refcursor);

    --7
    procedure SP_SELECT_GRANT(username in varchar2, userschema in varchar2, tablename in varchar2, cur out sys_refcursor);

    --8
    procedure SP_SELECT_GRANT_USER(username in varchar2, cur out sys_refcursor);

    --9
    procedure SP_GRANT_REVOKE(username in varchar2, schema_user in varchar2, pro_tab in varchar2, type_pro in varchar2, dk in number);

    --10
    procedure SP_GRANT_REVOKE_ROLES(username in varchar2, roles in varchar2, dk in number);
end;
/
create or replace package body PHANQUYEN
as
    --1
    procedure SP_SELECT_PROCEDURE_USER(useowner in varchar2, pro_type in varchar2, cur out sys_refcursor)
    is
    begin
        open cur for
            select object_name from dba_procedures where owner = useowner and object_type = pro_type;
    end;

    --2
    procedure SP_SELECT_USER(cur out sys_refcursor)
    is
    begin
        open cur for
            select username from dba_users where account_status = 'OPEN';
    end;

    --3
    procedure SP_SELECT_ROLES(cur out sys_refcursor)
    is
    begin
        open cur for
            select role from dba_roles;
    end;

    --4
    procedure SP_USER_ROLES(username in varchar2, cur out sys_refcursor)
    is
    begin
        open cur for
            select granted_role from dba_role_privs where grantee = username;
    end;

    --5
    procedure SP_USER_ROLES_CHECK(username in varchar2, roles in varchar2, cout out number)
    is
    begin
        select COUNT(*) into cout from dba_role_privs where grantee = username and granted_role = roles;
    end;

    --6
    procedure SP_SELECT_TABLE(username in varchar2, cur out sys_refcursor)
    is
    begin
        open cur for
            select table_name from dba_all_tables where owner = username;
    end;

    --7
    procedure SP_SELECT_GRANT(username in varchar2, userschema in varchar2, tablename in varchar2, cur out sys_refcursor)
    is
    begin
        open cur for
            select privilege from dba_tab_privs where grantee = username and table_name = tablename and owner = userschema;
    end;

    --8
    procedure SP_SELECT_GRANT_USER(username in varchar2, cur out sys_refcursor)
    is
    begin
        open cur for
            select table_name, type, owner from dba_tab_privs where grantee = username and type in ('PROCEDURE', 'FUNCTION', 'PACKAGE');
    end;

    --9
    procedure SP_GRANT_REVOKE(username in varchar2, schema_user in varchar2, pro_tab in varchar2, type_pro in varchar2, dk in number)
    is
    begin
        if dk = 1 then
            execute immediate 'GRANT ' || type_pro || ' ON ' || schema_user || '.' || pro_tab || ' TO ' || username;
        else
            execute immediate 'REVOKE ' || type_pro || ' ON ' || schema_user || '.' || pro_tab || ' FROM ' || username;
        end if;
    end; 

    --10
    procedure SP_GRANT_REVOKE_ROLES(username in varchar2, roles in varchar2, dk in number)
    is
    begin
        if dk = 1 then
            execute immediate 'GRANT ' || roles || ' TO ' || username;
        else
            execute immediate 'REVOKE ' || roles || ' FROM ' || username;
        end if;
    end;
end;