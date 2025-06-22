--SYS
/
create or replace procedure SP_SYS_SELECT_USER_DML(cur out sys_refcursor)
is
begin
    open cur for
        select username from dba_users order by username ASC;
end;
/

/
create or replace procedure SP_CREATE_AUDIT(p_statement in varchar2, p_username in varchar2)
as
    v_audit_command varchar2(400);
begin
    v_audit_command := 'AUDIT ' || p_statement || ' BY ' || p_username;

    execute immediate v_audit_command;
exception when others then
    raise;
end;
/
create or replace procedure SP_DROP_AUDIT(p_statement in varchar2, p_username in varchar2)
as
    v_audit_command varchar2(400);
begin
    v_audit_command := 'NoAUDIT ' || p_statement || ' BY ' || p_username;

    execute immediate v_audit_command;
exception when others then
    raise;
end;
/
create or replace procedure SP_SELECT_STMT_AUDIT_OPTS(username in varchar2, cur out sys_refcursor)
is
begin
    open cur for
        select * from dba_stmt_audit_opts
        where user_name = username;
end;
/
create or replace procedure SP_SELECT_AUDIT_TRAIL_USER(username in varchar2, cur out sys_refcursor)
is
begin
    open cur for
        select Session_ID, Extended_timestamp, DB_User, UserHost, Object_schema,
        Object_name, Statement_Type, SQL_Bind, SQL_Text
        from dba_common_audit_trail where AUDIT_TYPE = 'Standard Audit'
        and DB_USER = username and object_name = 'TAB'
        order by extended_timestamp DESC;
end;
/