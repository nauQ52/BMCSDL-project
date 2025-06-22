--
-- QUAN LY CUA HANG TIEN LOI
--

--
-- VIEW
--

-- VIEW TRUY VAN DEN BANG dba_users

CREATE VIEW V_USERS AS
SELECT account_status, username
FROM SYS.dba_users
/