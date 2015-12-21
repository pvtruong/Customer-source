alter table bangtinhluong add hoan_thue numeric(18,5)
GO
update bangtinhluong set hoan_thue =0 where hoan_thue is null