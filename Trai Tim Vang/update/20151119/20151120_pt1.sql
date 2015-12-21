alter table dpt1 add ma_nv varchar(16)
alter table dpt1 add ty_le_hh numeric(18,5)
alter table dpt1 add tien_hh numeric(18,5)
alter table dpt1 add tien_hh_nt numeric(18,5)
alter table dpt1 add tk_phi_hh varchar(16)
alter table dpt1 add tk_du_phi_hh varchar(16)
GO
exec notnull 'dpt1'
GO
ALTER VIEW [dbo].[vdpt1]
AS
SELECT    a.*
		,b.ten_tk as ten_tk_no,b.ten_tk2 as ten_tk_no2,b.tk_cn AS tk_cn_no,b.loai_cl_no
		,c.ten_tk as ten_tk_co,c.ten_tk2 as ten_tk_co2,c.tk_cn AS tk_cn_co,c.loai_cl_co
		,g.ten_kh
		,v.ten_nvu,v.ten_nvu2,f.ten_nv
FROM         dbo.Dpt1 AS a LEFT OUTER JOIN
                      dbo.dmtk AS b ON a.tk_no = b.tk
						 LEFT OUTER JOIN dbo.dmtk AS c ON a.tk_co = c.tk
						 LEFT OUTER JOIN dbo.dkh AS g ON a.ma_kh = g.ma_kh
						 left join dmnvu v on a.ma_nvu = v.ma_nvu
						 left join dnv f on a.ma_nv = f.ma_nv



				

GO


delete  from fieldlookup where code in ('BC1','PT1')


INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'tdttno', N'ma_nvu', N'ma_nvu,ten_nvu,tk_no', N'ma_nvu,ten_nvu,tk_no', N'ma_nvu,ten_nvu2,tk_no', N'ma_nvu,ten_nvu2,tk_no', N'dmnvu', 1, N'(ma_ct='''' or dbo.einstr(''BC1'',ma_ct)=1)', 1, N'exists(select 1 from options where name =''notnull_mnv'' and value1=1 and [tien_nt]<>0)', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'tdttno', N'tk_no', N'tk', N'tk_no', N'tk', N'tk_no', N'dmtk', 0, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'ma_kh', N'ma_kh,ten_kh', N'ma_kh,ten_kh', N'ma_kh,ten_kh2', N'ma_kh,ten_kh2', N'dmkh', 1, N'1=1', 1, N'exists(select 1 from dmtk where tk =@[tk_co] and tk_cn =1)', N'', 1, 0, N'3', 1 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'ma_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', N'dmnv', 1, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'ma_nvu', N'ma_nvu,ten_nvu,tk_no,tk_co', N'ma_nvu,ten_nvu,tk_no,tk_co', N'ma_nvu,ten_nvu2,tk_no,tk_co', N'ma_nvu,ten_nvu2,tk_no,tk_co', N'dmnvu', 1, N'(ma_ct='''' or dbo.einstr(''BC1'',ma_ct)=1)', 1, N'exists(select 1 from options where name =''notnull_mnv'' and value1=1 and [tien_nt]<>0)', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'tk_co', N'tk,ten_tk,tk_cn,loai_cl_co', N'tk_co,ten_tk_co,tk_cn_co,loai_cl_co', N'tk,ten_tk2,tk_cn,loai_cl_co', N'tk_co,ten_tk_co2,tk_cn_co,loai_cl_co', N'dmtk', 0, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'tk_du_phi_hh', N'tk', N'tk_du_phi_hh', N'tk', N'tk_du_phi_hh', N'dmtk', 1, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'tk_no', N'tk,ten_tk,tk_cn', N'tk_no,ten_tk_no,tk_cn_no', N'tk,ten_tk2,tk_cn', N'tk_no,ten_tk_no2,tk_cn_no', N'dmtk', 0, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'BC1', N'vdpt1', N'tk_phi_hh', N'tk', N'tk_phi_hh', N'tk', N'tk_phi_hh', N'dmtk', 1, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'tdttno', N'ma_nvu', N'ma_nvu,ten_nvu,tk_no', N'ma_nvu,ten_nvu,tk_no', N'ma_nvu,ten_nvu2,tk_no', N'ma_nvu,ten_nvu2,tk_no', N'dmnvu', 1, N'(ma_ct='''' or dbo.einstr(''PT1'',ma_ct)=1)', 1, N'exists(select 1 from options where name =''notnull_mnv'' and value1=1 and [tien_nt]<>0)', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'tdttno', N'tk_no', N'tk', N'tk_no', N'tk', N'tk_no', N'dmtk', 0, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'ma_kh', N'ma_kh,ten_kh', N'ma_kh,ten_kh', N'ma_kh,ten_kh2', N'ma_kh,ten_kh2', N'dmkh', 1, N'1=1', 1, N'exists(select 1 from dmtk where tk =@[tk_co] and tk_cn =1)', N'', 1, 0, N'3', 1 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'ma_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', N'dmnv', 1, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'ma_nvu', N'ma_nvu,ten_nvu,tk_no,tk_co', N'ma_nvu,ten_nvu,tk_no,tk_co', N'ma_nvu,ten_nvu2,tk_no,tk_co', N'ma_nvu,ten_nvu2,tk_no,tk_co', N'dmnvu', 1, N'(ma_ct='''' or dbo.einstr(''PT1'',ma_ct)=1)', 1, N'exists(select 1 from options where name =''notnull_mnv'' and value1=1 and [tien_nt]<>0)', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'tk_co', N'tk,ten_tk,tk_cn,loai_cl_co', N'tk_co,ten_tk_co,tk_cn_co,loai_cl_co', N'tk,ten_tk2,tk_cn,loai_cl_co', N'tk_co,ten_tk_co2,tk_cn_co,loai_cl_co', N'dmtk', 0, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'tk_du_phi_hh', N'tk', N'tk_du_phi_hh', N'tk', N'tk_du_phi_hh', N'dmtk', 1, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'tk_no', N'tk,ten_tk,tk_cn', N'tk_no,ten_tk_no,tk_cn_no', N'tk,ten_tk2,tk_cn', N'tk_no,ten_tk_no2,tk_cn_no', N'dmtk', 0, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )
INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PT1', N'vdpt1', N'tk_phi_hh', N'tk', N'tk_phi_hh', N'tk', N'tk_phi_hh', N'dmtk', 1, N'1=1', 1, N'', N'', 1, 0, N'3', 0 )

GO
delete  from voucherdetailinfo where voucherid ='pt1'
INSERT INTO voucherdetailinfo (voucherid,stt,tablename,viewname,gridid4input,table4import,gridid4import,store4import,key4import,trang_thai,title,title2,not_empty,allow_copy,columns_ht,columns_nt,next_row_when_press_enter,index_name ) VALUES ( N'PT1', N'1', N'dpt1', N'vdpt1', N'dpt1', N'dpt1_imp', N'dpt1_imp', N'', N'', 1, N'Chi tiết', N'Detail', 1, 1, N'tien,tien_hh', N'tien_nt,tien_hh_nt', 0, N'IX_F_dpt1' )
INSERT INTO voucherdetailinfo (voucherid,stt,tablename,viewname,gridid4input,table4import,gridid4import,store4import,key4import,trang_thai,title,title2,not_empty,allow_copy,columns_ht,columns_nt,next_row_when_press_enter,index_name ) VALUES ( N'PT1', N'2', N'tdttno', N'tdttno', N'dpt1_hd', N'', N'', N'', N'', 1, N'Thu theo hoá đơn', N'Thu theo hoá đơn', 1, 1, N'tien', N'tien_nt', 0, N'' )
GO
delete  from voucherdetailinfo where voucherid ='BC1'
INSERT INTO voucherdetailinfo (voucherid,stt,tablename,viewname,gridid4input,table4import,gridid4import,store4import,key4import,trang_thai,title,title2,not_empty,allow_copy,columns_ht,columns_nt,next_row_when_press_enter,index_name ) VALUES ( N'BC1', N'1', N'dpt1', N'vdpt1', N'dpt1', N'dpt1_imp', N'dpt1_imp', N'', N'', 1, N'Chi tiết', N'Detail', 1, 1, N'tien,tien_hh', N'tien_nt,tien_hh_nt', 0, N'IX_F_dpt1' )
INSERT INTO voucherdetailinfo (voucherid,stt,tablename,viewname,gridid4input,table4import,gridid4import,store4import,key4import,trang_thai,title,title2,not_empty,allow_copy,columns_ht,columns_nt,next_row_when_press_enter,index_name ) VALUES ( N'BC1', N'2', N'tdttno', N'tdttno', N'dpt1_hd', N'', N'', N'', N'', 1, N'Thu theo hóa đơn', N'Thu theo hóa đơn', 1, 1, N'tien', N'tien_nt', 0, N'' )
GO

ALTER PROCEDURE [dbo].[PostGLPT1]

@stt_rec as char(13),

@ma_ct as char(3)

As

	Begin

		DECLARE @tk_cl_no AS CHAR(16),@tk_cl_co AS CHAR(16),@ma_nt CHAR(3),@dtht CHAR(3),@ma_ct_cl CHAR(3),@dien_giai_m nvarchar(128)

		SET @ma_ct_cl = 'NT1'

		SELECT @dtht = value1 FROM options WHERE NAME ='a_dtht'

		SELECT @ma_nt =  ma_nt,@dien_giai_m = dien_giai FROM mpt1 WHERE stt_rec = @stt_rec AND ma_ct = @ma_ct



		--lay du lieu

		Select a.*,b.ma_dvcs,b.ma_kh AS ma_kh1,b.dien_giai AS dien_giai_m,b.so_ct AS so_ct1,b.ngay_ct AS ngay_ct1

		 INTO #tmp1 

		 From dpt1 a

		 Left join mpt1 b on a.stt_rec = b.stt_rec and a.ma_ct = b.ma_ct

		 Where a.stt_rec =  @stt_rec  

			 And a.ma_ct =  @ma_ct  and tk_no <> tk_co

		Update #tmp1 SET ma_kh = ma_kh1 WHERE ma_kh =''	 

		Update #tmp1 SET dien_giai = dien_giai_m WHERE dien_giai =''	 

		UPDATE #tmp1 SET so_ct = so_ct1,ngay_ct = ngay_ct1

	

	

		--tien hang

		SELECT stt_rec,ma_dvcs,ma_ct,ngay_ct,so_ct,tk_no, tk_co,dien_giai,ma_nt,max(ty_gia) as ty_gia,ma_kh

			,ma_bp,ma_phi,ma_dt,ma_hd,ma_d_tt,ma_sp,so_lsx,ma_nv,max(dien_giai_m) as dien_giai_m

			,sum(tien_nt) as tien_nt,sum(tien) as tien

			,MAX(ty_gia) AS ty_gia_gs_no

			,ty_gia_gs_co

			--,SUM(tien_nt * ty_gia) AS tien_no

			,sum(tien) as tien_no

			,SUM(tien_nt * ty_gia_gs_co) AS tien_co

			,CAST('' AS CHAR(13)) AS stt_rec_g
			,SUM(tien_nt) AS tien_goc_nt

		INTO #tmp 

		FROM #tmp1

		GROUP BY stt_rec,ma_dvcs,ma_ct,ngay_ct,so_ct,tk_no,tk_co,dien_giai,ma_nt,ma_kh,ma_bp,ma_phi,ma_dt,ma_hd,ma_d_tt,ma_sp,so_lsx,ma_nv,ty_gia_gs_co

		--tien hoa hong
		insert INTO #tmp 
		SELECT stt_rec,ma_dvcs,ma_ct,ngay_ct,so_ct,tk_phi_hh,tk_du_phi_hh,dien_giai,ma_nt,max(ty_gia) as ty_gia,ma_kh

			,ma_bp,ma_phi,ma_dt,ma_hd,ma_d_tt,ma_sp,so_lsx,ma_nv,max(dien_giai_m) as dien_giai_m

			,sum(tien_hh_nt) as tien_nt,sum(tien_hh) as tien

			,MAX(ty_gia) AS ty_gia_gs_no

			,ty_gia_gs_co

			--,SUM(tien_nt * ty_gia) AS tien_no

			,sum(tien) as tien_no

			,SUM(tien_nt * ty_gia_gs_co) AS tien_co

			,CAST('' AS CHAR(13)) AS stt_rec_g
			,SUM(tien_nt) AS tien_goc_nt
		FROM #tmp1 where tk_phi_hh <> '' and tk_du_phi_hh <> '' and tien_hh <> 0

		GROUP BY stt_rec,ma_dvcs,ma_ct,ngay_ct,so_ct,tk_phi_hh,tk_du_phi_hh,dien_giai,ma_nt,ma_kh,ma_bp,ma_phi,ma_dt,ma_hd,ma_d_tt,ma_sp,so_lsx,ma_nv,ty_gia_gs_co


		--tinh chenh lech ty gia

		IF upper(@ma_nt) <> upper(@dtht) AND EXISTS (SELECT 1 FROM options WHERE NAME ='a_tcltg' AND LTRIM(RTRIM(value1)) = '1')

			BEGIN

				--

				UPDATE #tmp SET tien = ty_gia * tien_nt WHERE tien = 0

				--khong tinh chenh lech neu 2 ty gia bang nhau
				update #tmp set tien_no = tien,tien_co = tien where ty_gia_gs_no = ty_gia_gs_co
				--

				UPDATE #tmp SET ty_gia_gs_co  = ty_gia,tien_co = tien_no WHERE tk_co  IN (SELECT tk FROM dmtk WHERE loai_cl_co =0)

				--tam lay ty gia giao dich neu ty gia dich danh = 0

				UPDATE #tmp SET ty_gia_gs_co  = ty_gia,tien_co = tien_no WHERE tien_co = 0

				--tinh tien

				UPDATE #tmp SET tien = tien_co,ty_gia =  ty_gia_gs_co WHERE (tien_no >= tien_co) AND ty_gia_gs_co <> 0

				

				UPDATE #tmp SET tien = tien_no,ty_gia =  ty_gia_gs_no WHERE (tien_no < tien_co)  AND ty_gia_gs_no <> 0



				--tao but toan chenh lech

				SELECT @tk_cl_no = tk_cl_no,@tk_cl_co = tk_cl_co  FROM dnt WHERE ma_nt  = @ma_nt

				SELECT * INTO #cl FROM #tmp WHERE tien_no <> tien_co

				UPDATE #cl SET tien_nt = 0,tien = (tien_no - tien_co),ma_ct = @ma_ct_cl,stt_rec_g = stt_rec,stt_rec = LEFT(stt_rec,1) + @ma_ct_cl + RIGHT(stt_rec,9)

				--lai

				UPDATE #cl SET tien = abs(tien),tk_co = @tk_cl_co WHERE tien_co < tien_no --ok

				--lo

				UPDATE #cl SET tien = abs(tien),tk_no = @tk_cl_no WHERE tien_co > tien_no

				INSERT INTO #tmp SELECT * FROM #cl

			END

		--ket qua

	

		DELETE socai WHERE stt_rec_g = @stt_rec

		SELECT * ,ROW_NUMBER() OVER (order by stt_rec,ma_dvcs,ma_ct,ngay_ct,so_ct,tk_no,tk_co,dien_giai,ma_nt,ma_kh,ma_bp,ma_phi,ma_dt,ma_hd,ma_d_tt,ma_sp,so_lsx,ma_nv) as line 

			FROM #tmp





	End


