using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ServerShared;

namespace ReportHopDong_PhuLuc_Vaccine;

public class rptPhuLucNoiDungGoiVaccineVNVC : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private PageHeaderBand PageHeader;

	private XRTable xrTable2;

	private XRTableRow xrTableRow2;

	private XRTableCell xrTableCell5;

	private XRTableCell xrTableCell6;

	private XRTableCell xrTableCell7;

	private XRTableCell xrTableCell8;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell1;

	private XRTableCell xrTableCell2;

	private XRTableCell xrTableCell3;

	private XRTableCell xrTableCell4;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private GroupFooterBand GroupFooter1;

	private XRTable xrTable3;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell11;

	private XRTableCell xrTableCell12;

	private PageFooterBand PageFooter;

	private XRLabel xrLabel27;

	private XRPageInfo xrPageInfo1;

	private XRTableCell xrTableCell10;

	private XRTableCell xrTableCell9;

	private XRTable xrTable4;

	private XRTableRow xrTableRow4;

	private XRTableCell xrTableCell13;

	private XRTableCell xrTableCell14;

	private rep_PhuLucHopDongVaccineV2 rep_PhuLucHopDongVaccineV21;

	private XRLabel xrLabel6;

	private XRLabel xrLabel7;

	private XRTable xrTable5;

	private XRTableRow xrTableRow5;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell16;

	private XRLabel xrLabel8;

	private ReportHeaderBand ReportHeader;

	private XRRichText xrRichText1;

	// Section header: STT | NỘI DUNG
	private XRTable xrTable6;
	private XRTableRow xrTableRow6;
	private XRTableCell xrTableCell17;
	private XRTableCell xrTableCell18;

	// Section I: I | Gói Vắc xin
	private XRTable xrTable7;
	private XRTableRow xrTableRow7;
	private XRTableCell xrTableCell19;
	private XRTableCell xrTableCell20;

	// Section II: II | Gói dịch vụ tại Khu vực VIP
	private XRTable xrTable8;
	private XRTableRow xrTableRow8;
	private XRTableCell xrTableCell21;
	private XRTableCell xrTableCell22;

	// VIP service header row
	private XRTable xrTable9;
	private XRTableRow xrTableRow9;
	private XRTableCell xrTableCell23;
	private XRTableCell xrTableCell24;
	private XRTableCell xrTableCell25;
	private XRTableCell xrTableCell26;

	// VIP service data row
	private XRTable xrTable10;
	private XRTableRow xrTableRow10;
	private XRTableCell xrTableCell27;
	private XRTableCell xrTableCell28;
	private XRTableCell xrTableCell29;
	private XRTableCell xrTableCell30;

	public rptPhuLucNoiDungGoiVaccineVNVC()
	{
		InitializeComponent();
		BeforePrint += rptPhuLucNoiDungGoiVaccineVNVC_BeforePrint;
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		rep_PhuLucHopDongVaccineV2 rep_PhuLucHopDongVaccineV3 = new rep_PhuLucHopDongVaccineV2();
		DataSetExtensions.ApplyDataSet((DataSet)rep_PhuLucHopDongVaccineV3, ds);
		dset = rep_PhuLucHopDongVaccineV3;
		((XtraReportBase)this).DataSource = rep_PhuLucHopDongVaccineV3;
		// Set VipSoLuong directly from incoming ds
		bool foundVipSL = false;
		for (int i = 0; i < ds.Tables.Count; i++)
		{
			if (ds.Tables[i].Columns.Contains("VipSoLuong") && ds.Tables[i].Rows.Count > 0)
			{
				object val = ds.Tables[i].Rows[0]["VipSoLuong"];
				((XRControl)xrTableCell30).Text = (val != DBNull.Value) ? Convert.ToString(val) : "DBNull";
				foundVipSL = true;
				break;
			}
		}
		if (!foundVipSL)
			((XRControl)xrTableCell30).Text = "NOT_IN_DS(" + ds.Tables.Count + ")";
		MemoryStream memoryStream = new MemoryStream();
		if (type.ToUpper() == "PDF")
		{
			((XtraReport)this).ExportToPdf((Stream)memoryStream);
		}
		if (type.ToUpper() == "XLS")
		{
			((XtraReport)this).ExportToXls((Stream)memoryStream);
		}
		if (type.ToUpper() == "HTML")
		{
			((XtraReport)this).ExportToHtml((Stream)memoryStream);
		}
		return new ReportResult(type, memoryStream.ToArray());
	}

	private void rptPhuLucNoiDungGoiVaccineVNVC_BeforePrint(object sender, PrintEventArgs e)
	{
		DataRow dataRow = DataExtensions.FirstRow(dset.Tables[1]);
		((XRControl)xrLabel1).Text = DataExtensions.Item(dataRow, "TenGoi");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected O, but got Unknown
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected O, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f1: Expected O, but got Unknown
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Unknown result type (might be due to invalid IL or missing references)
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1714: Expected O, but got Unknown
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1802: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1973: Expected O, but got Unknown
		//IL_19b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa6: Expected O, but got Unknown
		//IL_1abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c74: Expected O, but got Unknown
		//IL_1c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Expected O, but got Unknown
		//IL_1cbe: Unknown result type (might be due to invalid IL or missing references)
		XRSummary val = new XRSummary();
		XRSummary val2 = new XRSummary();
		XRSummary val3 = new XRSummary();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(rptPhuLucNoiDungGoiVaccineVNVC));
		Detail = new DetailBand();
		xrTable2 = new XRTable();
		xrTableRow2 = new XRTableRow();
		xrTableCell5 = new XRTableCell();
		xrTableCell6 = new XRTableCell();
		xrTableCell7 = new XRTableCell();
		xrTableCell10 = new XRTableCell();
		xrTableCell8 = new XRTableCell();
		TopMargin = new TopMarginBand();
		xrLabel1 = new XRLabel();
		BottomMargin = new BottomMarginBand();
		PageHeader = new PageHeaderBand();
		xrLabel8 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrTable1 = new XRTable();
		xrTableRow1 = new XRTableRow();
		xrTableCell1 = new XRTableCell();
		xrTableCell2 = new XRTableCell();
		xrTableCell3 = new XRTableCell();
		xrTableCell9 = new XRTableCell();
		xrTableCell4 = new XRTableCell();
		xrLabel5 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrLabel2 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		xrTable5 = new XRTable();
		xrTableRow5 = new XRTableRow();
		xrTableCell15 = new XRTableCell();
		xrTableCell16 = new XRTableCell();
		xrTable4 = new XRTable();
		xrTableRow4 = new XRTableRow();
		xrTableCell13 = new XRTableCell();
		xrTableCell14 = new XRTableCell();
		xrTable3 = new XRTable();
		xrTableRow3 = new XRTableRow();
		xrTableCell11 = new XRTableCell();
		xrTableCell12 = new XRTableCell();
		PageFooter = new PageFooterBand();
		xrLabel27 = new XRLabel();
		xrPageInfo1 = new XRPageInfo();
		rep_PhuLucHopDongVaccineV21 = new rep_PhuLucHopDongVaccineV2();
		ReportHeader = new ReportHeaderBand();
		xrRichText1 = new XRRichText();
		xrTable6 = new XRTable();
		xrTableRow6 = new XRTableRow();
		xrTableCell17 = new XRTableCell();
		xrTableCell18 = new XRTableCell();
		xrTable7 = new XRTable();
		xrTableRow7 = new XRTableRow();
		xrTableCell19 = new XRTableCell();
		xrTableCell20 = new XRTableCell();
		xrTable8 = new XRTable();
		xrTableRow8 = new XRTableRow();
		xrTableCell21 = new XRTableCell();
		xrTableCell22 = new XRTableCell();
		xrTable9 = new XRTable();
		xrTableRow9 = new XRTableRow();
		xrTableCell23 = new XRTableCell();
		xrTableCell24 = new XRTableCell();
		xrTableCell25 = new XRTableCell();
		xrTableCell26 = new XRTableCell();
		xrTable10 = new XRTable();
		xrTableRow10 = new XRTableRow();
		xrTableCell27 = new XRTableCell();
		xrTableCell28 = new XRTableCell();
		xrTableCell29 = new XRTableCell();
		xrTableCell30 = new XRTableCell();
		((ISupportInitialize)xrTable2).BeginInit();
		((ISupportInitialize)xrTable1).BeginInit();
		((ISupportInitialize)xrTable5).BeginInit();
		((ISupportInitialize)xrTable4).BeginInit();
		((ISupportInitialize)xrTable3).BeginInit();
		((ISupportInitialize)xrTable6).BeginInit();
		((ISupportInitialize)xrTable7).BeginInit();
		((ISupportInitialize)xrTable8).BeginInit();
		((ISupportInitialize)xrTable9).BeginInit();
		((ISupportInitialize)xrTable10).BeginInit();
		((ISupportInitialize)rep_PhuLucHopDongVaccineV21).BeginInit();
		((ISupportInitialize)xrRichText1).BeginInit();
		((ISupportInitialize)this).BeginInit();
		((XRControl)Detail).Controls.AddRange((XRControl[])(object)new XRControl[1] { (XRControl)xrTable2 });
		((XRControl)Detail).HeightF = 25f;
		((XRControl)Detail).Name = "Detail";
		((XRControl)Detail).Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		((XRControl)Detail).TextAlignment = (TextAlignment)1;
		((XRControl)xrTable2).Borders = (BorderSide)7;
		((XRControl)xrTable2).Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		((XRControl)xrTable2).LocationFloat = new PointFloat(22.83331f, 0f);
		((XRControl)xrTable2).Name = "xrTable2";
		((XRControl)xrTable2).Padding = new PaddingInfo(2, 2, 2, 2, 100f);
		xrTable2.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow2 });
		((XRControl)xrTable2).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable2).StylePriority.UseBorders = false;
		((XRControl)xrTable2).StylePriority.UseFont = false;
		((XRControl)xrTable2).StylePriority.UsePadding = false;
		((XRControl)xrTable2).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable2).TextAlignment = (TextAlignment)16;
		xrTableRow2.Cells.AddRange((XRTableCell[])(object)new XRTableCell[5] { xrTableCell5, xrTableCell6, xrTableCell7, xrTableCell10, xrTableCell8 });
		((XRControl)xrTableRow2).Name = "xrTableRow2";
		xrTableRow2.Weight = 1.0;
		((XRControl)xrTableCell5).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.ProductName")
		});
		((XRControl)xrTableCell5).Name = "xrTableCell5";
		((XRControl)xrTableCell5).Padding = new PaddingInfo(2, 2, 2, 2, 100f);
		((XRControl)xrTableCell5).StylePriority.UsePadding = false;
		((XRControl)xrTableCell5).StylePriority.UseTextAlignment = false;
		val.Func = (SummaryFunc)19;
		val.Running = (SummaryRunning)3;
		((XRLabel)xrTableCell5).Summary = val;
		((XRControl)xrTableCell5).Text = "xrTableCell5";
		((XRControl)xrTableCell5).TextAlignment = (TextAlignment)32;
		xrTableCell5.Weight = 0.4106238163423236;
		((XRControl)xrTableCell6).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.PhongBenh")
		});
		((XRControl)xrTableCell6).Name = "xrTableCell6";
		((XRControl)xrTableCell6).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell6).Text = "xrTableCell6";
		((XRControl)xrTableCell6).TextAlignment = (TextAlignment)16;
		xrTableCell6.Weight = 1.7712938333355837;
		((XRControl)xrTableCell7).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.ProductName")
		});
		((XRControl)xrTableCell7).Name = "xrTableCell7";
		((XRControl)xrTableCell7).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell7).Text = "xrTableCell7";
		((XRControl)xrTableCell7).TextAlignment = (TextAlignment)32;
		xrTableCell7.Weight = 1.3896677317615471;
		((XRControl)xrTableCell10).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.NuocSX")
		});
		((XRControl)xrTableCell10).Name = "xrTableCell10";
		((XRControl)xrTableCell10).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell10).Text = "xrTableCell10";
		((XRControl)xrTableCell10).TextAlignment = (TextAlignment)32;
		xrTableCell10.Weight = 0.9864095358002349;
		((XRControl)xrTableCell8).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.Qty")
		});
		((XRControl)xrTableCell8).Name = "xrTableCell8";
		((XRControl)xrTableCell8).Padding = new PaddingInfo(3, 3, 3, 3, 100f);
		((XRControl)xrTableCell8).StylePriority.UsePadding = false;
		((XRControl)xrTableCell8).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell8).Text = "xrTableCell8";
		((XRControl)xrTableCell8).TextAlignment = (TextAlignment)32;
		xrTableCell8.Weight = 1.0565885178189047;
		((XRControl)TopMargin).HeightF = 55.5f;
		((XRControl)TopMargin).Name = "TopMargin";
		((XRControl)TopMargin).Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		((XRControl)TopMargin).TextAlignment = (TextAlignment)1;
		((XRControl)xrLabel1).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table2.TenGoi")
		});
		((XRControl)xrLabel1).Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrLabel1).LocationFloat = new PointFloat(9.536743E-05f, 95.5417f);
		xrLabel1.Multiline = true;
		((XRControl)xrLabel1).Name = "xrLabel1";
		((XRControl)xrLabel1).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel1).SizeF = new SizeF(776.9999f, 36.75f);
		((XRControl)xrLabel1).StylePriority.UseFont = false;
		((XRControl)xrLabel1).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel1).Text = "xrLabel1";
		((XRControl)xrLabel1).TextAlignment = (TextAlignment)32;
		((XRControl)BottomMargin).HeightF = 0f;
		((XRControl)BottomMargin).Name = "BottomMargin";
		((XRControl)BottomMargin).Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		((XRControl)BottomMargin).TextAlignment = (TextAlignment)1;
		((XRControl)PageHeader).Controls.AddRange((XRControl[])(object)new XRControl[10]
		{
			(XRControl)xrLabel8,
			(XRControl)xrLabel7,
			(XRControl)xrLabel6,
			(XRControl)xrTable6,
			(XRControl)xrTable7,
			(XRControl)xrTable1,
			(XRControl)xrLabel5,
			(XRControl)xrLabel4,
			(XRControl)xrLabel3,
			(XRControl)xrLabel2
		});
		((XRControl)PageHeader).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)PageHeader).HeightF = 163.4166f;
		((XRControl)PageHeader).Name = "PageHeader";
		((XRControl)PageHeader).StylePriority.UseFont = false;
		((XRControl)xrLabel8).BorderColor = Color.Black;
		((XRControl)xrLabel8).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.NewContractName")
		});
		((XRControl)xrLabel8).Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrLabel8).ForeColor = Color.Black;
		((XRControl)xrLabel8).LocationFloat = new PointFloat(9.536743E-05f, 0f);
		((XRControl)xrLabel8).Name = "xrLabel8";
		((XRControl)xrLabel8).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel8).SizeF = new SizeF(776.9999f, 28.875f);
		((XRControl)xrLabel8).StylePriority.UseBorderColor = false;
		((XRControl)xrLabel8).StylePriority.UseFont = false;
		((XRControl)xrLabel8).StylePriority.UseForeColor = false;
		((XRControl)xrLabel8).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel8).Text = "xrLabel8";
		((XRControl)xrLabel8).TextAlignment = (TextAlignment)32;
		((XRControl)xrLabel7).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table2.Title2")
		});
		((XRControl)xrLabel7).Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrLabel7).LocationFloat = new PointFloat(50.90615f, 65.41669f);
		((XRControl)xrLabel7).Name = "xrLabel7";
		((XRControl)xrLabel7).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel7).SizeF = new SizeF(675.1354f, 23f);
		((XRControl)xrLabel7).StylePriority.UseFont = false;
		((XRControl)xrLabel7).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel7).Text = "xrLabel7";
		((XRControl)xrLabel7).TextAlignment = (TextAlignment)32;
		((XRControl)xrLabel6).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table2.Title")
		});
		((XRControl)xrLabel6).Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrLabel6).LocationFloat = new PointFloat(50.90615f, 42.41667f);
		((XRControl)xrLabel6).Name = "xrLabel6";
		((XRControl)xrLabel6).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel6).SizeF = new SizeF(675.1354f, 23f);
		((XRControl)xrLabel6).StylePriority.UseFont = false;
		((XRControl)xrLabel6).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel6).Text = "xrLabel6";
		((XRControl)xrLabel6).TextAlignment = (TextAlignment)32;
		((XRControl)xrTable1).Borders = (BorderSide)7;
		((XRControl)xrTable1).LocationFloat = new PointFloat(22.83331f, 138.41658f);
		((XRControl)xrTable1).Name = "xrTable1";
		xrTable1.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow1 });
		((XRControl)xrTable1).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable1).StylePriority.UseBorders = false;
		((XRControl)xrTable1).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable1).TextAlignment = (TextAlignment)32;
		xrTableRow1.Cells.AddRange((XRTableCell[])(object)new XRTableCell[5] { xrTableCell1, xrTableCell2, xrTableCell3, xrTableCell9, xrTableCell4 });
		((XRControl)xrTableRow1).Name = "xrTableRow1";
		xrTableRow1.Weight = 1.0;
		((XRControl)xrTableCell1).Name = "xrTableCell1";
		((XRControl)xrTableCell1).Text = "STT";
		xrTableCell1.Weight = 0.4106238163423236;
		((XRControl)xrTableCell2).Name = "xrTableCell2";
		((XRControl)xrTableCell2).Text = "Phòng bệnh";
		xrTableCell2.Weight = 1.7712938333355834;
		((XRControl)xrTableCell3).Name = "xrTableCell3";
		((XRControl)xrTableCell3).Text = "Tên vắc xin";
		xrTableCell3.Weight = 1.3896677317615476;
		((XRControl)xrTableCell9).Name = "xrTableCell9";
		((XRControl)xrTableCell9).Text = "Nước sản xuất";
		xrTableCell9.Weight = 0.9864102173875747;
		((XRControl)xrTableCell4).Name = "xrTableCell4";
		((XRControl)xrTableCell4).Text = "Số lượng (liều)";
		xrTableCell4.Weight = 1.0565878362315648;
		((XRControl)xrLabel5).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.MaKH")
		});
		((XRControl)xrLabel5).Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrLabel5).LocationFloat = new PointFloat(582.2917f, 42.41667f);
		((XRControl)xrLabel5).Name = "xrLabel5";
		((XRControl)xrLabel5).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel5).SizeF = new SizeF(81.25f, 23f);
		((XRControl)xrLabel5).StylePriority.UseFont = false;
		((XRControl)xrLabel5).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel5).Text = "xrLabel5";
		((XRControl)xrLabel5).TextAlignment = (TextAlignment)16;
		((XRControl)xrLabel5).Visible = false;
		((XRControl)xrLabel4).Font = new Font("Times New Roman", 12.75f);
		((XRControl)xrLabel4).LocationFloat = new PointFloat(462.5002f, 42.41667f);
		((XRControl)xrLabel4).Name = "xrLabel4";
		((XRControl)xrLabel4).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel4).SizeF = new SizeF(119.7916f, 23f);
		((XRControl)xrLabel4).StylePriority.UseFont = false;
		((XRControl)xrLabel4).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel4).Text = "- MÃ SỐ KH: ";
		((XRControl)xrLabel4).TextAlignment = (TextAlignment)16;
		((XRControl)xrLabel4).Visible = false;
		((XRControl)xrLabel3).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table1.TenKH")
		});
		((XRControl)xrLabel3).Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrLabel3).LocationFloat = new PointFloat(261.4584f, 42.41667f);
		((XRControl)xrLabel3).Name = "xrLabel3";
		((XRControl)xrLabel3).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel3).SizeF = new SizeF(201.0417f, 23f);
		((XRControl)xrLabel3).StylePriority.UseFont = false;
		((XRControl)xrLabel3).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel3).Text = "xrLabel3";
		((XRControl)xrLabel3).TextAlignment = (TextAlignment)16;
		((XRControl)xrLabel3).Visible = false;
		((XRControl)xrLabel2).Font = new Font("Times New Roman", 12.75f);
		((XRControl)xrLabel2).LocationFloat = new PointFloat(84.37503f, 42.41667f);
		((XRControl)xrLabel2).Name = "xrLabel2";
		((XRControl)xrLabel2).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel2).SizeF = new SizeF(177.0833f, 23f);
		((XRControl)xrLabel2).StylePriority.UseFont = false;
		((XRControl)xrLabel2).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel2).Text = "CỦA KHÁCH HÀNG:";
		((XRControl)xrLabel2).TextAlignment = (TextAlignment)16;
		((XRControl)xrLabel2).Visible = false;
		((XRControl)GroupFooter1).Controls.AddRange((XRControl[])(object)new XRControl[6]
		{
			(XRControl)xrTable5,
			(XRControl)xrTable4,
			(XRControl)xrTable3,
			(XRControl)xrTable8,
			(XRControl)xrTable9,
			(XRControl)xrTable10
		});
		((XRControl)GroupFooter1).HeightF = 175f;
		((XRControl)GroupFooter1).Name = "GroupFooter1";
		((XRControl)xrTable5).Borders = (BorderSide)13;
		((XRControl)xrTable5).LocationFloat = new PointFloat(22.83328f, 125f);
		((XRControl)xrTable5).Name = "xrTable5";
		xrTable5.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow5 });
		((XRControl)xrTable5).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable5).StylePriority.UseBorders = false;
		((XRControl)xrTable5).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable5).TextAlignment = (TextAlignment)32;
		xrTableRow5.Cells.AddRange((XRTableCell[])(object)new XRTableCell[1] { xrTableCell15 });
		((XRControl)xrTableRow5).Name = "xrTableRow5";
		xrTableRow5.Weight = 1.0;
		((XRControl)xrTableCell15).Controls.AddRange((XRControl[])(object)new XRControl[1] { (XRControl)xrRichText1 });
		((XRControl)xrTableCell15).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTableCell15).Name = "xrTableCell15";
		((XRControl)xrTableCell15).Padding = new PaddingInfo(10, 10, 0, 0, 100f);
		((XRControl)xrTableCell15).StylePriority.UseFont = false;
		((XRControl)xrTableCell15).StylePriority.UsePadding = false;
		((XRControl)xrTableCell15).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell15).Text = "xrTableCell15";
		((XRControl)xrTableCell15).TextAlignment = (TextAlignment)16;
		xrTableCell15.Weight = 5.614583435058593;
		((XRControl)xrTableCell16).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTableCell16).Name = "xrTableCell16";
		((XRControl)xrTableCell16).Padding = new PaddingInfo(3, 3, 3, 3, 100f);
		((XRControl)xrTableCell16).StylePriority.UseFont = false;
		((XRControl)xrTableCell16).StylePriority.UsePadding = false;
		((XRControl)xrTableCell16).StylePriority.UseTextAlignment = false;
		val2.Func = (SummaryFunc)7;
		((XRLabel)xrTableCell16).Summary = val2;
		((XRControl)xrTableCell16).TextAlignment = (TextAlignment)64;
		xrTableCell16.Weight = 1.0565887450146842;
		((XRControl)xrTable4).Borders = (BorderSide)15;
		((XRControl)xrTable4).LocationFloat = new PointFloat(22.83331f, 100f);
		((XRControl)xrTable4).Name = "xrTable4";
		xrTable4.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow4 });
		((XRControl)xrTable4).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable4).StylePriority.UseBorders = false;
		((XRControl)xrTable4).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable4).TextAlignment = (TextAlignment)32;
		xrTableRow4.Cells.AddRange((XRTableCell[])(object)new XRTableCell[2] { xrTableCell13, xrTableCell14 });
		((XRControl)xrTableRow4).Name = "xrTableRow4";
		xrTableRow4.Weight = 1.0;
		((XRControl)xrTableCell13).Borders = (BorderSide)11;
		((XRControl)xrTableCell13).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTableCell13).Name = "xrTableCell13";
		((XRControl)xrTableCell13).StylePriority.UseBorders = false;
		((XRControl)xrTableCell13).StylePriority.UseFont = false;
		((XRControl)xrTableCell13).Text = "Tổng giá trị Phụ lục";
		xrTableCell13.Weight = 4.557994690043909;
		((XRControl)xrTableCell14).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table2.TongTien", "{0:n0} VNĐ")
		});
		((XRControl)xrTableCell14).Borders = (BorderSide)14;
		((XRControl)xrTableCell14).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTableCell14).Name = "xrTableCell14";
		((XRControl)xrTableCell14).Padding = new PaddingInfo(3, 3, 3, 3, 100f);
		((XRControl)xrTableCell14).StylePriority.UseBorders = false;
		((XRControl)xrTableCell14).StylePriority.UseFont = false;
		((XRControl)xrTableCell14).StylePriority.UsePadding = false;
		((XRControl)xrTableCell14).StylePriority.UseTextAlignment = false;
		val3.Func = (SummaryFunc)7;
		((XRLabel)xrTableCell14).Summary = val3;
		((XRControl)xrTableCell14).Text = "xrTableCell14";
		((XRControl)xrTableCell14).TextAlignment = (TextAlignment)64;
		xrTableCell14.Weight = 1.0565887450146842;
		((XRControl)xrTable3).Borders = (BorderSide)15;
		((XRControl)xrTable3).LocationFloat = new PointFloat(22.83331f, 0f);
		((XRControl)xrTable3).Name = "xrTable3";
		xrTable3.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow3 });
		((XRControl)xrTable3).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable3).StylePriority.UseBorders = false;
		((XRControl)xrTable3).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable3).TextAlignment = (TextAlignment)32;
		xrTableRow3.Cells.AddRange((XRTableCell[])(object)new XRTableCell[2] { xrTableCell11, xrTableCell12 });
		((XRControl)xrTableRow3).Name = "xrTableRow3";
		xrTableRow3.Weight = 1.0;
		((XRControl)xrTableCell11).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTableCell11).Name = "xrTableCell11";
		((XRControl)xrTableCell11).StylePriority.UseFont = false;
		((XRControl)xrTableCell11).Text = "Tổng số (liều):";
		xrTableCell11.Weight = 4.55799423565235;
		((XRControl)xrTableCell12).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table2.TongSL")
		});
		((XRControl)xrTableCell12).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTableCell12).Name = "xrTableCell12";
		((XRControl)xrTableCell12).Padding = new PaddingInfo(3, 3, 3, 3, 100f);
		((XRControl)xrTableCell12).StylePriority.UseFont = false;
		((XRControl)xrTableCell12).StylePriority.UsePadding = false;
		((XRControl)xrTableCell12).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell12).Text = "xrTableCell12";
		((XRControl)xrTableCell12).TextAlignment = (TextAlignment)32;
		xrTableCell12.Weight = 1.0565891994062442;
		//
		// xrTable6 - STT | NỘI DUNG (PageHeader)
		//
		((XRControl)xrTable6).Borders = (BorderSide)15;
		((XRControl)xrTable6).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTable6).LocationFloat = new PointFloat(22.83331f, 88.41658f);
		((XRControl)xrTable6).Name = "xrTable6";
		xrTable6.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow6 });
		((XRControl)xrTable6).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable6).StylePriority.UseBorders = false;
		((XRControl)xrTable6).StylePriority.UseFont = false;
		((XRControl)xrTable6).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable6).TextAlignment = (TextAlignment)32;
		xrTableRow6.Cells.AddRange((XRTableCell[])(object)new XRTableCell[2] { xrTableCell17, xrTableCell18 });
		((XRControl)xrTableRow6).Name = "xrTableRow6";
		xrTableRow6.Weight = 1.0;
		((XRControl)xrTableCell17).Name = "xrTableCell17";
		((XRControl)xrTableCell17).Text = "STT";
		xrTableCell17.Weight = 0.4106238163423236;
		((XRControl)xrTableCell18).Name = "xrTableCell18";
		((XRControl)xrTableCell18).Text = "NỘI DUNG";
		xrTableCell18.Weight = 5.2035596187162704;
		//
		// xrTable7 - I | Gói Vắc xin (PageHeader)
		//
		((XRControl)xrTable7).Borders = (BorderSide)7;
		((XRControl)xrTable7).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTable7).LocationFloat = new PointFloat(22.83331f, 113.41658f);
		((XRControl)xrTable7).Name = "xrTable7";
		xrTable7.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow7 });
		((XRControl)xrTable7).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable7).StylePriority.UseBorders = false;
		((XRControl)xrTable7).StylePriority.UseFont = false;
		((XRControl)xrTable7).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable7).TextAlignment = (TextAlignment)32;
		xrTableRow7.Cells.AddRange((XRTableCell[])(object)new XRTableCell[2] { xrTableCell19, xrTableCell20 });
		((XRControl)xrTableRow7).Name = "xrTableRow7";
		xrTableRow7.Weight = 1.0;
		((XRControl)xrTableCell19).Name = "xrTableCell19";
		((XRControl)xrTableCell19).Text = "I";
		((XRControl)xrTableCell19).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell19).TextAlignment = (TextAlignment)32;
		xrTableCell19.Weight = 0.4106238163423236;
		((XRControl)xrTableCell20).Name = "xrTableCell20";
		((XRControl)xrTableCell20).Text = "Gói Vắc xin";
		((XRControl)xrTableCell20).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell20).TextAlignment = (TextAlignment)32;
		xrTableCell20.Weight = 5.2035596187162704;
		//
		// xrTable8 - II | Gói dịch vụ tại Khu vực VIP (GroupFooter)
		//
		((XRControl)xrTable8).Borders = (BorderSide)7;
		((XRControl)xrTable8).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTable8).LocationFloat = new PointFloat(22.83331f, 25f);
		((XRControl)xrTable8).Name = "xrTable8";
		xrTable8.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow8 });
		((XRControl)xrTable8).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable8).StylePriority.UseBorders = false;
		((XRControl)xrTable8).StylePriority.UseFont = false;
		((XRControl)xrTable8).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable8).TextAlignment = (TextAlignment)32;
		xrTableRow8.Cells.AddRange((XRTableCell[])(object)new XRTableCell[2] { xrTableCell21, xrTableCell22 });
		((XRControl)xrTableRow8).Name = "xrTableRow8";
		xrTableRow8.Weight = 1.0;
		((XRControl)xrTableCell21).Name = "xrTableCell21";
		((XRControl)xrTableCell21).Text = "II";
		((XRControl)xrTableCell21).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell21).TextAlignment = (TextAlignment)32;
		xrTableCell21.Weight = 0.4106238163423236;
		((XRControl)xrTableCell22).Name = "xrTableCell22";
		((XRControl)xrTableCell22).Text = "Gói dịch vụ tại Khu vực VIP";
		((XRControl)xrTableCell22).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell22).TextAlignment = (TextAlignment)32;
		xrTableCell22.Weight = 5.2035596187162704;
		//
		// xrTable9 - VIP header (GroupFooter)
		//
		((XRControl)xrTable9).Borders = (BorderSide)7;
		((XRControl)xrTable9).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrTable9).LocationFloat = new PointFloat(22.83331f, 50f);
		((XRControl)xrTable9).Name = "xrTable9";
		xrTable9.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow9 });
		((XRControl)xrTable9).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable9).StylePriority.UseBorders = false;
		((XRControl)xrTable9).StylePriority.UseFont = false;
		((XRControl)xrTable9).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable9).TextAlignment = (TextAlignment)32;
		xrTableRow9.Cells.AddRange((XRTableCell[])(object)new XRTableCell[4] { xrTableCell23, xrTableCell24, xrTableCell25, xrTableCell26 });
		((XRControl)xrTableRow9).Name = "xrTableRow9";
		xrTableRow9.Weight = 1.0;
		((XRControl)xrTableCell23).Name = "xrTableCell23";
		((XRControl)xrTableCell23).Text = "";
		xrTableCell23.Weight = 0.4106238163423236;
		((XRControl)xrTableCell24).Name = "xrTableCell24";
		((XRControl)xrTableCell24).Text = "Dịch vụ";
		xrTableCell24.Weight = 3.1609615650971310;
		((XRControl)xrTableCell25).Name = "xrTableCell25";
		((XRControl)xrTableCell25).Text = "Đơn vị tính";
		xrTableCell25.Weight = 0.9864102173875747;
		((XRControl)xrTableCell26).Name = "xrTableCell26";
		((XRControl)xrTableCell26).Text = "Số lượng";
		xrTableCell26.Weight = 1.0565878362315648;
		//
		// xrTable10 - VIP data row (GroupFooter)
		//
		((XRControl)xrTable10).Borders = (BorderSide)7;
		((XRControl)xrTable10).Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		((XRControl)xrTable10).LocationFloat = new PointFloat(22.83331f, 75f);
		((XRControl)xrTable10).Name = "xrTable10";
		xrTable10.Rows.AddRange((XRTableRow[])(object)new XRTableRow[1] { xrTableRow10 });
		((XRControl)xrTable10).SizeF = new SizeF(754.1667f, 25f);
		((XRControl)xrTable10).StylePriority.UseBorders = false;
		((XRControl)xrTable10).StylePriority.UseFont = false;
		((XRControl)xrTable10).StylePriority.UseTextAlignment = false;
		((XRControl)xrTable10).TextAlignment = (TextAlignment)16;
		xrTableRow10.Cells.AddRange((XRTableCell[])(object)new XRTableCell[4] { xrTableCell27, xrTableCell28, xrTableCell29, xrTableCell30 });
		((XRControl)xrTableRow10).Name = "xrTableRow10";
		xrTableRow10.Weight = 1.0;
		((XRControl)xrTableCell27).Name = "xrTableCell27";
		((XRControl)xrTableCell27).Text = "1";
		((XRControl)xrTableCell27).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell27).TextAlignment = (TextAlignment)32;
		xrTableCell27.Weight = 0.4106238163423236;
		((XRControl)xrTableCell28).Name = "xrTableCell28";
		((XRControl)xrTableCell28).Text = "Sử dụng dịch vụ tại khu vực VIP";
		((XRControl)xrTableCell28).Padding = new PaddingInfo(5, 2, 2, 2, 100f);
		((XRControl)xrTableCell28).StylePriority.UsePadding = false;
		((XRControl)xrTableCell28).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell28).TextAlignment = (TextAlignment)16;
		xrTableCell28.Weight = 3.1609615650971310;
		((XRControl)xrTableCell29).Name = "xrTableCell29";
		((XRControl)xrTableCell29).Text = "Lần";
		((XRControl)xrTableCell29).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell29).TextAlignment = (TextAlignment)32;
		xrTableCell29.Weight = 0.9864102173875747;
		((XRControl)xrTableCell30).Name = "xrTableCell30";
		((XRControl)xrTableCell30).StylePriority.UseTextAlignment = false;
		((XRControl)xrTableCell30).TextAlignment = (TextAlignment)32;
		xrTableCell30.Weight = 1.0565878362315648;
		((XRControl)PageFooter).Controls.AddRange((XRControl[])(object)new XRControl[2]
		{
			(XRControl)xrLabel27,
			(XRControl)xrPageInfo1
		});
		((XRControl)PageFooter).HeightF = 20f;
		((XRControl)PageFooter).Name = "PageFooter";
		((XRControl)xrLabel27).DataBindings.AddRange((XRBinding[])(object)new XRBinding[1]
		{
			new XRBinding("Text", (object)null, "Table2.NgayIn")
		});
		((XRControl)xrLabel27).LocationFloat = new PointFloat(0f, 0f);
		((XRControl)xrLabel27).Name = "xrLabel27";
		((XRControl)xrLabel27).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrLabel27).SizeF = new SizeF(279.1667f, 20f);
		((XRControl)xrLabel27).StylePriority.UseTextAlignment = false;
		((XRControl)xrLabel27).Text = "xrLabel27";
		((XRControl)xrLabel27).TextAlignment = (TextAlignment)16;
		xrPageInfo1.Format = "Trang {0}/{1}";
		((XRControl)xrPageInfo1).LocationFloat = new PointFloat(569.2823f, 0f);
		((XRControl)xrPageInfo1).Name = "xrPageInfo1";
		((XRControl)xrPageInfo1).Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		((XRControl)xrPageInfo1).SizeF = new SizeF(207.7177f, 20f);
		((XRControl)xrPageInfo1).StylePriority.UseTextAlignment = false;
		((XRControl)xrPageInfo1).TextAlignment = (TextAlignment)64;
		rep_PhuLucHopDongVaccineV21.DataSetName = "rep_PhuLucHopDongVaccineV2";
		rep_PhuLucHopDongVaccineV21.Locale = new CultureInfo("en-US");
		rep_PhuLucHopDongVaccineV21.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((XRControl)ReportHeader).Controls.AddRange((XRControl[])(object)new XRControl[1] { (XRControl)xrLabel1 });
		((XRControl)ReportHeader).HeightF = 132.2917f;
		((XRControl)ReportHeader).Name = "ReportHeader";
		((XRControl)xrRichText1).DataBindings.AddRange((XRBinding[])(object)new XRBinding[2]
		{
			new XRBinding("Rtf", (object)null, "Table2.ThoiHanGoi"),
			new XRBinding("Html", (object)null, "Table2.ThoiHanGoi")
		});
		((XRControl)xrRichText1).Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		((XRControl)xrRichText1).LocationFloat = new PointFloat(2.670288E-05f, 0f);
		((XRControl)xrRichText1).Name = "xrRichText1";
		((XRRichTextBase)xrRichText1).SerializableRtfString = componentResourceManager.GetString("xrRichText1.SerializableRtfString");
		((XRControl)xrRichText1).SizeF = new SizeF(754.1667f, 25f);
		((XtraReportBase)this).Bands.AddRange((Band[])(object)new Band[7]
		{
			(Band)Detail,
			(Band)TopMargin,
			(Band)BottomMargin,
			(Band)PageHeader,
			(Band)GroupFooter1,
			(Band)PageFooter,
			(Band)ReportHeader
		});
		((XtraReportBase)this).DataMember = "Table1";
		((XtraReportBase)this).DataSource = rep_PhuLucHopDongVaccineV21;
		((XtraReport)this).Margins = new Margins(25, 25, 56, 0);
		((XtraReport)this).PageHeight = 1169;
		((XtraReport)this).PageWidth = 827;
		((XtraReport)this).PaperKind = PaperKind.A4;
		((XtraReport)this).Version = "12.2";
		//((XRControl)this).BeforePrint += rptPhuLucNoiDungGoiVaccineVNVC_BeforePrint;
		((ISupportInitialize)xrTable2).EndInit();
		((ISupportInitialize)xrTable1).EndInit();
		((ISupportInitialize)xrTable5).EndInit();
		((ISupportInitialize)xrTable4).EndInit();
		((ISupportInitialize)xrTable3).EndInit();
		((ISupportInitialize)xrTable6).EndInit();
		((ISupportInitialize)xrTable7).EndInit();
		((ISupportInitialize)xrTable8).EndInit();
		((ISupportInitialize)xrTable9).EndInit();
		((ISupportInitialize)xrTable10).EndInit();
		((ISupportInitialize)rep_PhuLucHopDongVaccineV21).EndInit();
		((ISupportInitialize)xrRichText1).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
