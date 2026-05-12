using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ReportHopDong_PhuLuc_Vaccine;

[Serializable]
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("rep_PhuLucHopDongVaccineV2")]
public class rep_PhuLucHopDongVaccineV2 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table1RowChangeEventHandler(object sender, Table1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table2RowChangeEventHandler(object sender, Table2RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table1DataTable : TypedTableBase<Table1Row>
	{
		private DataColumn columnHopDongID;

		private DataColumn columnSoHDong;

		private DataColumn columnPatientID;

		private DataColumn columnGoiID;

		private DataColumn columnProductName;

		private DataColumn columnTenKH;

		private DataColumn columnMaKH;

		private DataColumn columnTenGoi;

		private DataColumn columnMaChung;

		private DataColumn columnPhongBenh;

		private DataColumn columnNuocSX;

		private DataColumn columnQty;

		private DataColumn columnGia;

		private DataColumn columnNewContractName;

		private DataColumn columnThoiHanGoi2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HopDongIDColumn => columnHopDongID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SoHDongColumn => columnSoHDong;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PatientIDColumn => columnPatientID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn GoiIDColumn => columnGoiID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProductNameColumn => columnProductName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TenKHColumn => columnTenKH;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MaKHColumn => columnMaKH;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TenGoiColumn => columnTenGoi;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MaChungColumn => columnMaChung;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PhongBenhColumn => columnPhongBenh;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NuocSXColumn => columnNuocSX;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QtyColumn => columnQty;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn GiaColumn => columnGia;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NewContractNameColumn => columnNewContractName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ThoiHanGoi2Column => columnThoiHanGoi2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row this[int index] => (Table1Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1DataTable()
		{
			base.TableName = "Table1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table1DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Table1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable1Row(Table1Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row AddTable1Row(string HopDongID, string SoHDong, string PatientID, int GoiID, string ProductName, string TenKH, string MaKH, string TenGoi, string MaChung, string PhongBenh, string NuocSX, int Qty, decimal Gia, string NewContractName, string ThoiHanGoi2)
		{
			Table1Row table1Row = (Table1Row)NewRow();
			object[] itemArray = new object[15]
			{
				HopDongID, SoHDong, PatientID, GoiID, ProductName, TenKH, MaKH, TenGoi, MaChung, PhongBenh,
				NuocSX, Qty, Gia, NewContractName, ThoiHanGoi2
			};
			table1Row.ItemArray = itemArray;
			base.Rows.Add(table1Row);
			return table1Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Table1DataTable table1DataTable = (Table1DataTable)base.Clone();
			table1DataTable.InitVars();
			return table1DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Table1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnHopDongID = base.Columns["HopDongID"];
			columnSoHDong = base.Columns["SoHDong"];
			columnPatientID = base.Columns["PatientID"];
			columnGoiID = base.Columns["GoiID"];
			columnProductName = base.Columns["ProductName"];
			columnTenKH = base.Columns["TenKH"];
			columnMaKH = base.Columns["MaKH"];
			columnTenGoi = base.Columns["TenGoi"];
			columnMaChung = base.Columns["MaChung"];
			columnPhongBenh = base.Columns["PhongBenh"];
			columnNuocSX = base.Columns["NuocSX"];
			columnQty = base.Columns["Qty"];
			columnGia = base.Columns["Gia"];
			columnNewContractName = base.Columns["NewContractName"];
			columnThoiHanGoi2 = base.Columns["ThoiHanGoi2"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnHopDongID = new DataColumn("HopDongID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHopDongID);
			columnSoHDong = new DataColumn("SoHDong", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoHDong);
			columnPatientID = new DataColumn("PatientID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPatientID);
			columnGoiID = new DataColumn("GoiID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnGoiID);
			columnProductName = new DataColumn("ProductName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnProductName);
			columnTenKH = new DataColumn("TenKH", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenKH);
			columnMaKH = new DataColumn("MaKH", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaKH);
			columnTenGoi = new DataColumn("TenGoi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenGoi);
			columnMaChung = new DataColumn("MaChung", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaChung);
			columnPhongBenh = new DataColumn("PhongBenh", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPhongBenh);
			columnNuocSX = new DataColumn("NuocSX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNuocSX);
			columnQty = new DataColumn("Qty", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnQty);
			columnGia = new DataColumn("Gia", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnGia);
			columnNewContractName = new DataColumn("NewContractName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNewContractName);
			columnThoiHanGoi2 = new DataColumn("ThoiHanGoi2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnThoiHanGoi2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row NewTable1Row()
		{
			return (Table1Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table1Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Table1Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table1RowChanged != null)
			{
				this.Table1RowChanged(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table1RowChanging != null)
			{
				this.Table1RowChanging(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table1RowDeleted != null)
			{
				this.Table1RowDeleted(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table1RowDeleting != null)
			{
				this.Table1RowDeleting(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveTable1Row(Table1Row row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhuLucHopDongVaccineV2 rep_PhuLucHopDongVaccineV3 = new rep_PhuLucHopDongVaccineV2();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhuLucHopDongVaccineV3.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhuLucHopDongVaccineV3.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table2DataTable : TypedTableBase<Table2Row>
	{
		private DataColumn columnTenGoi;

		private DataColumn columnTongSL;

		private DataColumn columnTongTien;

		private DataColumn columnTitle;

		private DataColumn columnTitle2;

		private DataColumn columnThoiHanGoi;

		private DataColumn columnNewContractName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TenGoiColumn => columnTenGoi;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TongSLColumn => columnTongSL;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TongTienColumn => columnTongTien;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TitleColumn => columnTitle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Title2Column => columnTitle2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ThoiHanGoiColumn => columnThoiHanGoi;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NewContractNameColumn => columnNewContractName;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2Row this[int index] => (Table2Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2DataTable()
		{
			base.TableName = "Table2";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table2DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Table2DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable2Row(Table2Row row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2Row AddTable2Row(string TenGoi, int TongSL, decimal TongTien, string Title, string Title2, string ThoiHanGoi, string NewContractName)
		{
			Table2Row table2Row = (Table2Row)NewRow();
			object[] itemArray = new object[7] { TenGoi, TongSL, TongTien, Title, Title2, ThoiHanGoi, NewContractName };
			table2Row.ItemArray = itemArray;
			base.Rows.Add(table2Row);
			return table2Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Table2DataTable table2DataTable = (Table2DataTable)base.Clone();
			table2DataTable.InitVars();
			return table2DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Table2DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnTenGoi = base.Columns["TenGoi"];
			columnTongSL = base.Columns["TongSL"];
			columnTongTien = base.Columns["TongTien"];
			columnTitle = base.Columns["Title"];
			columnTitle2 = base.Columns["Title2"];
			columnThoiHanGoi = base.Columns["ThoiHanGoi"];
			columnNewContractName = base.Columns["NewContractName"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTenGoi = new DataColumn("TenGoi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenGoi);
			columnTongSL = new DataColumn("TongSL", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTongSL);
			columnTongTien = new DataColumn("TongTien", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTongTien);
			columnTitle = new DataColumn("Title", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTitle);
			columnTitle2 = new DataColumn("Title2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTitle2);
			columnThoiHanGoi = new DataColumn("ThoiHanGoi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnThoiHanGoi);
			columnNewContractName = new DataColumn("NewContractName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNewContractName);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2Row NewTable2Row()
		{
			return (Table2Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table2Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Table2Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table2RowChanged != null)
			{
				this.Table2RowChanged(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table2RowChanging != null)
			{
				this.Table2RowChanging(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table2RowDeleted != null)
			{
				this.Table2RowDeleted(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table2RowDeleting != null)
			{
				this.Table2RowDeleting(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveTable2Row(Table2Row row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhuLucHopDongVaccineV2 rep_PhuLucHopDongVaccineV3 = new rep_PhuLucHopDongVaccineV2();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhuLucHopDongVaccineV3.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table2DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhuLucHopDongVaccineV3.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class Table1Row : DataRow
	{
		private Table1DataTable tableTable1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HopDongID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.HopDongIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HopDongID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.HopDongIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SoHDong
		{
			get
			{
				try
				{
					return (string)base[tableTable1.SoHDongColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoHDong' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.SoHDongColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PatientID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.PatientIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PatientID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.PatientIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int GoiID
		{
			get
			{
				try
				{
					return (int)base[tableTable1.GoiIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GoiID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.GoiIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ProductName
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ProductNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ProductName' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ProductNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TenKH
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenKHColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenKH' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenKHColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string MaKH
		{
			get
			{
				try
				{
					return (string)base[tableTable1.MaKHColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaKH' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.MaKHColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TenGoi
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenGoiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenGoi' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenGoiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string MaChung
		{
			get
			{
				try
				{
					return (string)base[tableTable1.MaChungColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaChung' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.MaChungColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PhongBenh
		{
			get
			{
				try
				{
					return (string)base[tableTable1.PhongBenhColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PhongBenh' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.PhongBenhColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NuocSX
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NuocSXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NuocSX' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NuocSXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Qty
		{
			get
			{
				try
				{
					return (int)base[tableTable1.QtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Qty' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.QtyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal Gia
		{
			get
			{
				try
				{
					return (decimal)base[tableTable1.GiaColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Gia' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.GiaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NewContractName
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NewContractNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NewContractName' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NewContractNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ThoiHanGoi2
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ThoiHanGoi2Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThoiHanGoi2' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ThoiHanGoi2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable1 = (Table1DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHopDongIDNull()
		{
			return IsNull(tableTable1.HopDongIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHopDongIDNull()
		{
			base[tableTable1.HopDongIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSoHDongNull()
		{
			return IsNull(tableTable1.SoHDongColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSoHDongNull()
		{
			base[tableTable1.SoHDongColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPatientIDNull()
		{
			return IsNull(tableTable1.PatientIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPatientIDNull()
		{
			base[tableTable1.PatientIDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGoiIDNull()
		{
			return IsNull(tableTable1.GoiIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoiIDNull()
		{
			base[tableTable1.GoiIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsProductNameNull()
		{
			return IsNull(tableTable1.ProductNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetProductNameNull()
		{
			base[tableTable1.ProductNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTenKHNull()
		{
			return IsNull(tableTable1.TenKHColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenKHNull()
		{
			base[tableTable1.TenKHColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMaKHNull()
		{
			return IsNull(tableTable1.MaKHColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMaKHNull()
		{
			base[tableTable1.MaKHColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTenGoiNull()
		{
			return IsNull(tableTable1.TenGoiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenGoiNull()
		{
			base[tableTable1.TenGoiColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMaChungNull()
		{
			return IsNull(tableTable1.MaChungColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMaChungNull()
		{
			base[tableTable1.MaChungColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPhongBenhNull()
		{
			return IsNull(tableTable1.PhongBenhColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPhongBenhNull()
		{
			base[tableTable1.PhongBenhColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNuocSXNull()
		{
			return IsNull(tableTable1.NuocSXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNuocSXNull()
		{
			base[tableTable1.NuocSXColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQtyNull()
		{
			return IsNull(tableTable1.QtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQtyNull()
		{
			base[tableTable1.QtyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsGiaNull()
		{
			return IsNull(tableTable1.GiaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetGiaNull()
		{
			base[tableTable1.GiaColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNewContractNameNull()
		{
			return IsNull(tableTable1.NewContractNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNewContractNameNull()
		{
			base[tableTable1.NewContractNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThoiHanGoi2Null()
		{
			return IsNull(tableTable1.ThoiHanGoi2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetThoiHanGoi2Null()
		{
			base[tableTable1.ThoiHanGoi2Column] = Convert.DBNull;
		}
	}

	public class Table2Row : DataRow
	{
		private Table2DataTable tableTable2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TenGoi
		{
			get
			{
				try
				{
					return (string)base[tableTable2.TenGoiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenGoi' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.TenGoiColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int TongSL
		{
			get
			{
				try
				{
					return (int)base[tableTable2.TongSLColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TongSL' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.TongSLColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal TongTien
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.TongTienColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TongTien' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.TongTienColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Title
		{
			get
			{
				try
				{
					return (string)base[tableTable2.TitleColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Title' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.TitleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Title2
		{
			get
			{
				try
				{
					return (string)base[tableTable2.Title2Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Title2' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.Title2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ThoiHanGoi
		{
			get
			{
				try
				{
					return (string)base[tableTable2.ThoiHanGoiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThoiHanGoi' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ThoiHanGoiColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NewContractName
		{
			get
			{
				try
				{
					return (string)base[tableTable2.NewContractNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NewContractName' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.NewContractNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table2Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable2 = (Table2DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTenGoiNull()
		{
			return IsNull(tableTable2.TenGoiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenGoiNull()
		{
			base[tableTable2.TenGoiColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTongSLNull()
		{
			return IsNull(tableTable2.TongSLColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTongSLNull()
		{
			base[tableTable2.TongSLColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTongTienNull()
		{
			return IsNull(tableTable2.TongTienColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTongTienNull()
		{
			base[tableTable2.TongTienColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTitleNull()
		{
			return IsNull(tableTable2.TitleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTitleNull()
		{
			base[tableTable2.TitleColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTitle2Null()
		{
			return IsNull(tableTable2.Title2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTitle2Null()
		{
			base[tableTable2.Title2Column] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThoiHanGoiNull()
		{
			return IsNull(tableTable2.ThoiHanGoiColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetThoiHanGoiNull()
		{
			base[tableTable2.ThoiHanGoiColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNewContractNameNull()
		{
			return IsNull(tableTable2.NewContractNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNewContractNameNull()
		{
			base[tableTable2.NewContractNameColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table1RowChangeEvent : EventArgs
	{
		private Table1Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1RowChangeEvent(Table1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table2RowChangeEvent : EventArgs
	{
		private Table2Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2RowChangeEvent(Table2Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Table1DataTable tableTable1;

	private Table2DataTable tableTable2;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public Table1DataTable Table1 => tableTable1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public Table2DataTable Table2 => tableTable2;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public rep_PhuLucHopDongVaccineV2()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected rep_PhuLucHopDongVaccineV2(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table2"] != null)
			{
				base.Tables.Add(new Table2DataTable(dataSet.Tables["Table2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		rep_PhuLucHopDongVaccineV2 rep_PhuLucHopDongVaccineV3 = (rep_PhuLucHopDongVaccineV2)base.Clone();
		rep_PhuLucHopDongVaccineV3.InitVars();
		rep_PhuLucHopDongVaccineV3.SchemaSerializationMode = SchemaSerializationMode;
		return rep_PhuLucHopDongVaccineV3;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table2"] != null)
			{
				base.Tables.Add(new Table2DataTable(dataSet.Tables["Table2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableTable1 = (Table1DataTable)base.Tables["Table1"];
		if (initTable && tableTable1 != null)
		{
			tableTable1.InitVars();
		}
		tableTable2 = (Table2DataTable)base.Tables["Table2"];
		if (initTable && tableTable2 != null)
		{
			tableTable2.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "rep_PhuLucHopDongVaccineV2";
		base.Prefix = "";
		base.Locale = new CultureInfo("en-US");
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableTable1 = new Table1DataTable();
		base.Tables.Add(tableTable1);
		tableTable2 = new Table2DataTable();
		base.Tables.Add(tableTable2);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeTable1()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeTable2()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		rep_PhuLucHopDongVaccineV2 rep_PhuLucHopDongVaccineV3 = new rep_PhuLucHopDongVaccineV2();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = rep_PhuLucHopDongVaccineV3.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = rep_PhuLucHopDongVaccineV3.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
