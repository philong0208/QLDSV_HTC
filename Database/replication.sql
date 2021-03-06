/****** Scripting replication configuration. Script Date: 12/10/2021 10:24:47 AM ******/
/****** Please Note: For security reasons, all password parameters were scripted with either NULL or an empty string. ******/

/****** Begin: Script to be run at Publisher ******/

/****** Installing the server as a Distributor. Script Date: 12/10/2021 10:24:47 AM ******/
use master
exec sp_adddistributor @distributor = N'PHILONG', @password = N''
GO

-- Adding the agent profiles
-- Updating the agent profile defaults
exec sp_MSupdate_agenttype_default @profile_id = 1
GO
exec sp_MSupdate_agenttype_default @profile_id = 2
GO
exec sp_MSupdate_agenttype_default @profile_id = 4
GO
exec sp_MSupdate_agenttype_default @profile_id = 6
GO
exec sp_MSupdate_agenttype_default @profile_id = 11
GO

-- Adding the distribution databases
use master
exec sp_adddistributiondb @database = N'distribution', @data_folder = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Data', @data_file = N'distribution.MDF', @data_file_size = 13, @log_folder = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Data', @log_file = N'distribution.LDF', @log_file_size = 73, @min_distretention = 0, @max_distretention = 72, @history_retention = 48, @deletebatchsize_xact = 5000, @deletebatchsize_cmd = 2000, @security_mode = 1
GO

-- Adding the distribution publishers
exec sp_adddistpublisher @publisher = N'PHILONG', @distribution_db = N'distribution', @security_mode = 0, @login = N'sa', @password = N'', @working_directory = N'D:\MS SQL Server\REPLDATA', @trusted = N'false', @thirdparty_flag = 0, @publisher_type = N'MSSQLSERVER'
GO


/****** End: Script to be run at Publisher ******/


-- Enabling the replication database
use master
exec sp_replicationdboption @dbname = N'QLDSV_HTC', @optname = N'merge publish', @value = N'true'
GO

-- Adding the merge publication
use [QLDSV_HTC]
exec sp_addmergepublication @publication = N'QLDSV_HTC_CNTT', @description = N'KHOA CNTT', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'true', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'QLDSV_HTC_CNTT', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'PHILONG\PHI LONG'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'NT SERVICE\MSSQLSERVER'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_CNTT', @login = N'distributor_admin'
GO

-- Adding the merge articles
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'KHOA', @source_owner = N'dbo', @source_object = N'KHOA', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'[MAKHOA] = ''CNTT''', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'MONHOC', @source_owner = N'dbo', @source_object = N'MONHOC', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'GIANGVIEN', @source_owner = N'dbo', @source_object = N'GIANGVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'LOP', @source_owner = N'dbo', @source_object = N'LOP', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SINHVIEN', @source_owner = N'dbo', @source_object = N'SINHVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'LOPTINCHI', @source_owner = N'dbo', @source_object = N'LOPTINCHI', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'DANGKY', @source_owner = N'dbo', @source_object = N'DANGKY', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'CHECK_LOPTC', @source_owner = N'dbo', @source_object = N'CHECK_LOPTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'CHECK_LOPTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_CHECKID', @source_owner = N'dbo', @source_object = N'SP_CHECKID', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKID', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_CHECKIDHOCPHI', @source_owner = N'dbo', @source_object = N'SP_CHECKIDHOCPHI', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKIDHOCPHI', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_CHECKIDHOCPHIBYMASV', @source_owner = N'dbo', @source_object = N'SP_CHECKIDHOCPHIBYMASV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKIDHOCPHIBYMASV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_CHECKNAME', @source_owner = N'dbo', @source_object = N'SP_CHECKNAME', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKNAME', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_DANG_KY_MON', @source_owner = N'dbo', @source_object = N'SP_DANG_KY_MON', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANG_KY_MON', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_DANGNHAP', @source_owner = N'dbo', @source_object = N'SP_DANGNHAP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANGNHAP', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_DANGNHAPSV', @source_owner = N'dbo', @source_object = N'SP_DANGNHAPSV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANGNHAPSV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_DKMH', @source_owner = N'dbo', @source_object = N'SP_DKMH', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DKMH', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_DSLTC', @source_owner = N'dbo', @source_object = N'SP_DSLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DSLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_GET_DSMH_BY_MASV', @source_owner = N'dbo', @source_object = N'SP_GET_DSMH_BY_MASV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_GET_DSMH_BY_MASV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_GETDSNHAPDIEM', @source_owner = N'dbo', @source_object = N'SP_GETDSNHAPDIEM', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_GETDSNHAPDIEM', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_HUY_DANGKY_MON', @source_owner = N'dbo', @source_object = N'SP_HUY_DANGKY_MON', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_HUY_DANGKY_MON', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_INSERT_DIEM', @source_owner = N'dbo', @source_object = N'SP_INSERT_DIEM', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_INSERT_DIEM', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_Lay_Thong_Tin_NV_Tu_Login', @source_owner = N'dbo', @source_object = N'SP_Lay_Thong_Tin_NV_Tu_Login', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_Lay_Thong_Tin_NV_Tu_Login', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_REGISTER', @source_owner = N'dbo', @source_object = N'SP_REGISTER', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_REGISTER', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_RP__DSLTC', @source_owner = N'dbo', @source_object = N'SP_RP__DSLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP__DSLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_RP_BDMHLTC', @source_owner = N'dbo', @source_object = N'SP_RP_BDMHLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_BDMHLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_RP_BDTK', @source_owner = N'dbo', @source_object = N'SP_RP_BDTK', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_BDTK', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_RP_DSDHP', @source_owner = N'dbo', @source_object = N'SP_RP_DSDHP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_DSDHP', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_RP_DSSVDKLTC', @source_owner = N'dbo', @source_object = N'SP_RP_DSSVDKLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_DSSVDKLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_RP_PD', @source_owner = N'dbo', @source_object = N'SP_RP_PD', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_PD', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'SP_TAOLOGIN', @source_owner = N'dbo', @source_object = N'SP_TAOLOGIN', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_TAOLOGIN', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'V_DS_PHANMANH', @source_owner = N'dbo', @source_object = N'V_DS_PHANMANH', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_DS_PHANMANH', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'V_GV', @source_owner = N'dbo', @source_object = N'V_GV', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_GV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'V_MONHOC', @source_owner = N'dbo', @source_object = N'V_MONHOC', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_MONHOC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_CNTT', @article = N'Xoa_Login', @source_owner = N'dbo', @source_object = N'Xoa_Login', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'Xoa_Login', @force_reinit_subscription = 1
GO

-- Adding the merge article join filters
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_CNTT', @article = N'LOP', @filtername = N'LOP_KHOA', @join_articlename = N'KHOA', @join_filterclause = N'[LOP].[MAKHOA] = [KHOA].[MAKHOA]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_CNTT', @article = N'LOPTINCHI', @filtername = N'LOPTINCHI_KHOA', @join_articlename = N'KHOA', @join_filterclause = N'[LOPTINCHI].[MAKHOA] = [KHOA].[MAKHOA]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_CNTT', @article = N'SINHVIEN', @filtername = N'SINHVIEN_LOP', @join_articlename = N'LOP', @join_filterclause = N'[SINHVIEN].[MALOP] = [LOP].[MALOP]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_CNTT', @article = N'DANGKY', @filtername = N'DANGKY_SINHVIEN', @join_articlename = N'SINHVIEN', @join_filterclause = N'[SINHVIEN].[MASV] = [DANGKY].[MASV]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLDSV_HTC]
exec sp_addmergesubscription @publication = N'QLDSV_HTC_CNTT', @subscriber = N'PHILONG\SERVER1', @subscriber_db = N'QLDSV_HTC', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLDSV_HTC_CNTT', @subscriber = N'PHILONG\SERVER1', @subscriber_db = N'QLDSV_HTC', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO

-- Adding the merge publication
use [QLDSV_HTC]
exec sp_addmergepublication @publication = N'QLDSV_HTC_HOCPHI', @description = N'HOC PHI', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'false', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'QLDSV_HTC_HOCPHI', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'PHILONG\PHI LONG'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'NT SERVICE\MSSQLSERVER'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_HOCPHI', @login = N'distributor_admin'
GO

-- Adding the merge articles
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'KHOA', @source_owner = N'dbo', @source_object = N'KHOA', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'GIANGVIEN', @source_owner = N'dbo', @source_object = N'GIANGVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'true', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'GIANGVIEN', @column = N'MAGV', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'GIANGVIEN', @column = N'MAKHOA', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'GIANGVIEN', @column = N'HO', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'GIANGVIEN', @column = N'TEN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'GIANGVIEN', @column = N'rowguid', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'LOP', @source_owner = N'dbo', @source_object = N'LOP', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @source_owner = N'dbo', @source_object = N'SINHVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'true', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @column = N'MASV', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @column = N'HO', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @column = N'TEN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @column = N'MALOP', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @column = N'DANGHIHOC', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLDSV_HTC_HOCPHI', @article = N'SINHVIEN', @column = N'rowguid', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'HOCPHI', @source_owner = N'dbo', @source_object = N'HOCPHI', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'CT_DONGHOCPHI', @source_owner = N'dbo', @source_object = N'CT_DONGHOCPHI', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'ADD_HOCPHI', @source_owner = N'dbo', @source_object = N'ADD_HOCPHI', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'ADD_HOCPHI', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'GET_THONGTIN_HOCPHI', @source_owner = N'dbo', @source_object = N'GET_THONGTIN_HOCPHI', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'GET_THONGTIN_HOCPHI', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'GET_THONGTIN_HOCPHI_SV', @source_owner = N'dbo', @source_object = N'GET_THONGTIN_HOCPHI_SV', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'GET_THONGTIN_HOCPHI_SV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'SP_CHECKID', @source_owner = N'dbo', @source_object = N'SP_CHECKID', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKID', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'SP_CHECKIDHOCPHI', @source_owner = N'dbo', @source_object = N'SP_CHECKIDHOCPHI', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKIDHOCPHI', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'SP_CHECKIDHOCPHIBYMASV', @source_owner = N'dbo', @source_object = N'SP_CHECKIDHOCPHIBYMASV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKIDHOCPHIBYMASV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'SP_DANGNHAP', @source_owner = N'dbo', @source_object = N'SP_DANGNHAP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANGNHAP', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_HOCPHI', @article = N'SP_RP_DSDHP', @source_owner = N'dbo', @source_object = N'SP_RP_DSDHP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_DSDHP', @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLDSV_HTC]
exec sp_addmergesubscription @publication = N'QLDSV_HTC_HOCPHI', @subscriber = N'PHILONG\SERVER3', @subscriber_db = N'QLDSV_HTC', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLDSV_HTC_HOCPHI', @subscriber = N'PHILONG\SERVER3', @subscriber_db = N'QLDSV_HTC', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO

-- Adding the merge publication
use [QLDSV_HTC]
exec sp_addmergepublication @publication = N'QLDSV_HTC_VT', @description = N'KHOA VT', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'true', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'QLDSV_HTC_VT', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'PHILONG\PHI LONG'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'NT SERVICE\MSSQLSERVER'
GO
exec sp_grant_publication_access @publication = N'QLDSV_HTC_VT', @login = N'distributor_admin'
GO

-- Adding the merge articles
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'KHOA', @source_owner = N'dbo', @source_object = N'KHOA', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'[MAKHOA] = ''VT''', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'MONHOC', @source_owner = N'dbo', @source_object = N'MONHOC', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'GIANGVIEN', @source_owner = N'dbo', @source_object = N'GIANGVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'LOP', @source_owner = N'dbo', @source_object = N'LOP', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SINHVIEN', @source_owner = N'dbo', @source_object = N'SINHVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'LOPTINCHI', @source_owner = N'dbo', @source_object = N'LOPTINCHI', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'DANGKY', @source_owner = N'dbo', @source_object = N'DANGKY', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'CHECK_LOPTC', @source_owner = N'dbo', @source_object = N'CHECK_LOPTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'CHECK_LOPTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_CHECKID', @source_owner = N'dbo', @source_object = N'SP_CHECKID', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKID', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_CHECKIDHOCPHI', @source_owner = N'dbo', @source_object = N'SP_CHECKIDHOCPHI', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKIDHOCPHI', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_CHECKIDHOCPHIBYMASV', @source_owner = N'dbo', @source_object = N'SP_CHECKIDHOCPHIBYMASV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKIDHOCPHIBYMASV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_CHECKNAME', @source_owner = N'dbo', @source_object = N'SP_CHECKNAME', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_CHECKNAME', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_DANG_KY_MON', @source_owner = N'dbo', @source_object = N'SP_DANG_KY_MON', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANG_KY_MON', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_DANGNHAP', @source_owner = N'dbo', @source_object = N'SP_DANGNHAP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANGNHAP', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_DANGNHAPSV', @source_owner = N'dbo', @source_object = N'SP_DANGNHAPSV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DANGNHAPSV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_DKMH', @source_owner = N'dbo', @source_object = N'SP_DKMH', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DKMH', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_DSLTC', @source_owner = N'dbo', @source_object = N'SP_DSLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_DSLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_GET_DSMH_BY_MASV', @source_owner = N'dbo', @source_object = N'SP_GET_DSMH_BY_MASV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_GET_DSMH_BY_MASV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_GETDSNHAPDIEM', @source_owner = N'dbo', @source_object = N'SP_GETDSNHAPDIEM', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_GETDSNHAPDIEM', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_HUY_DANGKY_MON', @source_owner = N'dbo', @source_object = N'SP_HUY_DANGKY_MON', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_HUY_DANGKY_MON', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_INSERT_DIEM', @source_owner = N'dbo', @source_object = N'SP_INSERT_DIEM', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_INSERT_DIEM', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_Lay_Thong_Tin_NV_Tu_Login', @source_owner = N'dbo', @source_object = N'SP_Lay_Thong_Tin_NV_Tu_Login', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_Lay_Thong_Tin_NV_Tu_Login', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_REGISTER', @source_owner = N'dbo', @source_object = N'SP_REGISTER', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_REGISTER', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_RP__DSLTC', @source_owner = N'dbo', @source_object = N'SP_RP__DSLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP__DSLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_RP_BDMHLTC', @source_owner = N'dbo', @source_object = N'SP_RP_BDMHLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_BDMHLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_RP_BDTK', @source_owner = N'dbo', @source_object = N'SP_RP_BDTK', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_BDTK', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_RP_DSDHP', @source_owner = N'dbo', @source_object = N'SP_RP_DSDHP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_DSDHP', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_RP_DSSVDKLTC', @source_owner = N'dbo', @source_object = N'SP_RP_DSSVDKLTC', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_DSSVDKLTC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_RP_PD', @source_owner = N'dbo', @source_object = N'SP_RP_PD', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_RP_PD', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'SP_TAOLOGIN', @source_owner = N'dbo', @source_object = N'SP_TAOLOGIN', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_TAOLOGIN', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'V_DS_PHANMANH', @source_owner = N'dbo', @source_object = N'V_DS_PHANMANH', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_DS_PHANMANH', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'V_GV', @source_owner = N'dbo', @source_object = N'V_GV', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_GV', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'V_MONHOC', @source_owner = N'dbo', @source_object = N'V_MONHOC', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_MONHOC', @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergearticle @publication = N'QLDSV_HTC_VT', @article = N'Xoa_Login', @source_owner = N'dbo', @source_object = N'Xoa_Login', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'Xoa_Login', @force_reinit_subscription = 1
GO

-- Adding the merge article join filters
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_VT', @article = N'LOP', @filtername = N'LOP_KHOA', @join_articlename = N'KHOA', @join_filterclause = N'[LOP].[MAKHOA] = [KHOA].[MAKHOA]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_VT', @article = N'LOPTINCHI', @filtername = N'LOPTINCHI_KHOA', @join_articlename = N'KHOA', @join_filterclause = N'[LOPTINCHI].[MAKHOA] = [KHOA].[MAKHOA]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_VT', @article = N'SINHVIEN', @filtername = N'SINHVIEN_LOP', @join_articlename = N'LOP', @join_filterclause = N'[SINHVIEN].[MALOP] = [LOP].[MALOP]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV_HTC]
exec sp_addmergefilter @publication = N'QLDSV_HTC_VT', @article = N'DANGKY', @filtername = N'DANGKY_SINHVIEN', @join_articlename = N'SINHVIEN', @join_filterclause = N'[SINHVIEN].[MASV] = [DANGKY].[MASV]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLDSV_HTC]
exec sp_addmergesubscription @publication = N'QLDSV_HTC_VT', @subscriber = N'PHILONG\SERVER2', @subscriber_db = N'QLDSV_HTC', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLDSV_HTC_VT', @subscriber = N'PHILONG\SERVER2', @subscriber_db = N'QLDSV_HTC', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO



