using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using DpSdkEngLib;
using DPSDKOPSLib;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
 // ERROR: Not supported in C#: OptionDeclaration
using Microsoft.VisualBasic.PowerPacks;
namespace _4PosBackOffice.NET
{
	internal partial class frmGRVPromotion : System.Windows.Forms.Form
	{
		private ADODB.Recordset withEventsField_adoPrimaryRS;
		public ADODB.Recordset adoPrimaryRS {
			get { return withEventsField_adoPrimaryRS; }
			set {
				if (withEventsField_adoPrimaryRS != null) {
					withEventsField_adoPrimaryRS.MoveComplete -= adoPrimaryRS_MoveComplete;
					withEventsField_adoPrimaryRS.WillChangeRecord -= adoPrimaryRS_WillChangeRecord;
				}
				withEventsField_adoPrimaryRS = value;
				if (withEventsField_adoPrimaryRS != null) {
					withEventsField_adoPrimaryRS.MoveComplete += adoPrimaryRS_MoveComplete;
					withEventsField_adoPrimaryRS.WillChangeRecord += adoPrimaryRS_WillChangeRecord;
				}
			}
		}
		bool mbChangedByCode;
		int mvBookMark;
		bool mbEditFlag;
		bool mbAddNewFlag;
		bool mbDataChanged;
		int gID;
		int p_Prom;
		bool p_Prom1;

		bool mbAddNewFlagID;
		List<TextBox> txtFields = new List<TextBox>();
		List<DateTimePicker> DTFields = new List<DateTimePicker>();
		List<CheckBox> chkFields = new List<CheckBox>();

		private void loadLanguage()
		{

			//frmPromotion = No Code [Edit Promotion Details]
			//rsLang.filter = "LanguageLayoutLnk_LanguageID=" & 0000
			//If rsLang.RecordCount Then frmPromotion.Caption = rsLang("LanguageLayoutLnk_Description"): frmPromotion.RightToLeft = rsLang("LanguageLayoutLnk_RightTL")

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1074;
			//Undo|Checked
			if (modRecordSet.rsLang.RecordCount){cmdCancel.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;cmdCancel.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1085;
			//Print|Checked
			if (modRecordSet.rsLang.RecordCount){cmdPrint.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;cmdPrint.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1004;
			//Exit|Checked
			if (modRecordSet.rsLang.RecordCount){cmdClose.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;cmdClose.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1010;
			//General|Checked
			if (modRecordSet.rsLang.RecordCount){_lbl_5.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;_lbl_5.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			//rsLang.filter = "LanguageLayoutLnk_LanguageID=" & 1139 'Promotion Name|Checked
			//If rsLang.RecordCount Then lblLabels(38).Caption = rsLang("LanguageLayoutLnk_Description"): lblLabels(38).RightToLeft = rsLang("LanguageLayoutLnk_RightTL")

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1140;
			//Start Date|Checked
			if (modRecordSet.rsLang.RecordCount){_lblLabels_0.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;_lblLabels_0.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1141;
			//End Date|Checked
			if (modRecordSet.rsLang.RecordCount){_lblLabels_1.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;_lblLabels_1.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1142;
			//From Time|Checked
			if (modRecordSet.rsLang.RecordCount){Label1.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;Label1.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1143;
			//To Time|Checked
			if (modRecordSet.rsLang.RecordCount){Label2.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;Label2.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 2463;
			//Disabled|Checked
			if (modRecordSet.rsLang.RecordCount){_chkFields_1.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;_chkFields_1.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1145;
			//Apply only to POS channel|Checked
			if (modRecordSet.rsLang.RecordCount){_chkFields_0.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;_chkFields_0.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1146;
			//Only for Specific Time|Checked
			if (modRecordSet.rsLang.RecordCount){_chkFields_2.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;_chkFields_2.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1147;
			//Add|Checked
			if (modRecordSet.rsLang.RecordCount){cmdAdd.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;cmdAdd.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsLang.filter = "LanguageLayoutLnk_LanguageID=" + 1148;
			//Delete|Checked
			if (modRecordSet.rsLang.RecordCount){cmdDelete.Text = modRecordSet.rsLang.Fields("LanguageLayoutLnk_Description").Value;cmdDelete.RightToLeft = modRecordSet.rsLang.Fields("LanguageLayoutLnk_RightTL").Value;}

			modRecordSet.rsHelp.filter = "Help_Section=0 AND Help_Form='" + this.Name + "'";
			//UPGRADE_ISSUE: Form property frmGRVPromotion.HelpContextID was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			if (modRecordSet.rsHelp.RecordCount)
				this.ToolTip1 = modRecordSet.rsHelp.Fields("Help_ContextID").Value;

		}

		private void buildDataControls()
		{
			//    doDataControl Me.cmbChannel, "SELECT ChannelID, Channel_Name FROM Channel ORDER BY ChannelID", "Customer_ChannelID", "ChannelID", "Channel_Name"
		}

		private void doDataControl(ref System.Windows.Forms.Control dataControl, ref string sql, ref string DataField, ref string boundColumn, ref string listField)
		{
			//Dim rs As ADODB.Recordset
			//rs = getRS(sql)
			//'UPGRADE_WARNING: Couldn't resolve default property of object dataControl.RowSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			//dataControl.RowSource = rs
			//'UPGRADE_ISSUE: Control method dataControl.DataSource was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			//dataControl.DataSource = adoPrimaryRS
			//UPGRADE_ISSUE: Control method dataControl.DataField was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			//dataControl.DataField = DataField
			//UPGRADE_WARNING: Couldn't resolve default property of object dataControl.boundColumn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			//dataControl.boundColumn = boundColumn
			//UPGRADE_WARNING: Couldn't resolve default property of object dataControl.listField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			//dataControl.listField = listField
		}

		public void loadItem(ref int id)
		{
			System.Windows.Forms.TextBox oText = null;
			DateTimePicker oDate = null;
			System.Windows.Forms.CheckBox oCheck = null;

			mbAddNewFlagID = false;

			 // ERROR: Not supported in C#: OnErrorStatement

			if (id) {
				p_Prom = id;
				adoPrimaryRS = modRecordSet.getRS(ref "select GRVPromotion.* from GRVPromotion WHERE PromotionID = " + id);
			} else {
				adoPrimaryRS = modRecordSet.getRS(ref "select * from GRVPromotion");
				adoPrimaryRS.AddNew();
				this.Text = this.Text + " [New record]";
				mbAddNewFlag = true;
				mbAddNewFlagID = true;
			}
			setup();
			foreach (TextBox oText_loopVariable in txtFields) {
				oText = oText_loopVariable;
				oText.DataBindings.Add(adoPrimaryRS);
				oText.MaxLength = adoPrimaryRS.Fields(oText.DataBindings).DefinedSize;
			}

			foreach (DateTimePicker oDate_loopVariable in DTFields) {
				oDate = oDate_loopVariable;
				oDate.DataBindings.Add(adoPrimaryRS);
			}

			//adoPrimaryRS("Promotion_SpeTime")
			//Bind the check boxes to the data provider
			foreach (CheckBox oCheck_loopVariable in chkFields) {
				oCheck = oCheck_loopVariable;
				oCheck.DataBindings.Add(adoPrimaryRS);
			}
			buildDataControls();
			mbDataChanged = false;
			loadItems();

			loadLanguage();
			ShowDialog();
		}
		private void setup()
		{
		}
		private void cmdAdd_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			int lID = 0;
			ADODB.Recordset rs = default(ADODB.Recordset);

			if (mbAddNewFlagID == true) {
				if (string.IsNullOrEmpty(txtFields[0].Text)) {
					Interaction.MsgBox("Deal name is invalid.");
					txtFields[0].Focus();
					return;
				}
				System.Windows.Forms.Application.DoEvents();
				if (update_Renamed()) {
					p_Prom = adoPrimaryRS.Fields("PromotionID").Value;
					if (chkFields[1].CheckState == 0) {
						modRecordSet.cnnDB.Execute("UPDATE GRVPromotion SET Promotion_StartDate = #" + DTFields[0].Value + "#, Promotion_EndDate = #" + DTFields[1].Value + "#, Promotion_StartTime = #" + DTFields[2].Value + "# ,Promotion_EndTime =#" + DTFields[3].Value + "# WHERE PromotionID = " + p_Prom + ";");
					}
				} else {
					return;
				}
			}

			lID = My.MyProject.Forms.frmStockList.getItem();
			string[,] DateArr = null;
			System.DateTime xDate = default(System.DateTime);
			System.DateTime yDate = default(System.DateTime);
			short xInt = 0;
			if (lID != 0) {
				 // ERROR: Not supported in C#: OnErrorStatement


				xInt = (DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, _DTFields_0.Value, _DTFields_1.Value) == 0 ? 1 : DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, _DTFields_0.Value, _DTFields_1.Value));
				DateArr = new string[xInt + 1, 2];

				xInt = 0;
				//For xDate = _DTFields_0.Value.Date To _DTFields_1.Value.Date
				while (_DTFields_0.Value.Date < _DTFields_1.Value.Date) {
					if (xDate == _DTFields_0.Value) {
						DateArr[xInt, 0] = Convert.ToString(xDate);
						DateArr[xInt, 1] = "S";
					} else if (xDate == _DTFields_1.Value) {
						DateArr[xInt, 0] = Convert.ToString(xDate);
						DateArr[xInt, 1] = "E";
					} else {
						DateArr[xInt, 0] = Convert.ToString(xDate);
						DateArr[xInt, 1] = "A";
					}
					xInt = xInt + 1;
				}
				//Next

				rs = modRecordSet.getRS(ref "SELECT GRVPromotion.Promotion_Name, GRVPromotionItem.PromotionItem_StockItemID, GRVPromotionItem.PromotionItem_Price, GRVPromotion.Promotion_StartDate, GRVPromotion.Promotion_EndDate FROM GRVPromotion INNER JOIN GRVPromotionItem ON GRVPromotion.PromotionID = GRVPromotionItem.PromotionItem_PromotionID WHERE (((GRVPromotionItem.PromotionItem_StockItemID)=" + lID + "));");
				if (rs.RecordCount > 0) {
					while (!rs.EOF) {
						xInt = 0;
						for (xInt = 0; xInt <= Information.UBound(DateArr); xInt++) {
							if (DateArr[xInt, 0] == rs.Fields("Promotion_StartDate").Value) {
								if (DateArr[xInt, 1] == "E") {
								} else {
									Interaction.MsgBox("Selected Item already part of '" + rs.Fields("Promotion_Name").Value + "' deal. Please use different date or exclude it from the other deals.");
									rs.MoveLast();
									rs.MoveNext();
									return;
								}

							} else if (DateArr[xInt, 0] == rs.Fields("Promotion_EndDate").Value) {
								if (DateArr[xInt, 1] == "S") {
								} else {
									Interaction.MsgBox("Selected Item already part of '" + rs.Fields("Promotion_Name").Value + "' deal. Please use different date or exclude it from the other deals.");
									rs.MoveLast();
									rs.MoveNext();
									return;
								}
							}
						}
						rs.MoveNext();
					}
				}

				rs = modRecordSet.getRS(ref "SELECT GRVPromotion.Promotion_Name, GRVPromotionItem.PromotionItem_StockItemID, GRVPromotionItem.PromotionItem_Price, GRVPromotion.Promotion_StartDate, GRVPromotion.Promotion_EndDate FROM GRVPromotion INNER JOIN GRVPromotionItem ON GRVPromotion.PromotionID = GRVPromotionItem.PromotionItem_PromotionID WHERE (((GRVPromotionItem.PromotionItem_StockItemID)=" + lID + ") AND ((GRVPromotion.Promotion_StartDate)<=#" + Strings.Format(_DTFields_0.Value, "yyyy/MM/dd") + "#) AND ((GRVPromotion.Promotion_EndDate)>=#" + Strings.Format(_DTFields_1.Value, "yyyy/MM/dd") + "#));");
				if (rs.RecordCount > 0) {
					Interaction.MsgBox("Selected Item already part of '" + rs.Fields("Promotion_Name").Value + "' deal. Please use different date or exclude it from the other deals.");
				} else {
					//cnnDB.Execute "INSERT INTO PromotionItem ( PromotionItem_PromotionID, PromotionItem_StockItemID, PromotionItem_Quantity, PromotionItem_Price ) SELECT " & adoPrimaryRS("PromotionID") & " AS [Set], CatalogueChannelLnk.CatalogueChannelLnk_StockItemID, 1,CatalogueChannelLnk.CatalogueChannelLnk_Price From CatalogueChannelLnk WHERE (((CatalogueChannelLnk.CatalogueChannelLnk_StockItemID)=" & lID & ") AND ((CatalogueChannelLnk.CatalogueChannelLnk_Quantity)=1) AND ((CatalogueChannelLnk.CatalogueChannelLnk_ChannelID)=1));"
					My.MyProject.Forms.frmGRVPromotionItem.loadItem(adoPrimaryRS.Fields("PromotionID").Value, lID);
					loadItems(lID);
				}
			}
		}
		private void cmdDelete_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			int lID = 0;
			if (lvPromotion.FocusedItem == null) {
			} else {
				if (Interaction.MsgBox("Are you sure you wish to remove " + lvPromotion.FocusedItem.Text + " from this Deal?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "DELETE") == MsgBoxResult.Yes) {
					lID = Convert.ToInt32(Strings.Split(lvPromotion.FocusedItem.Name, "_")[0]);
					modRecordSet.cnnDB.Execute("DELETE GRVPromotionItem.* From GRVPromotionItem WHERE GRVPromotionItem.PromotionItem_PromotionID=" + adoPrimaryRS.Fields("PromotionID").Value + " AND GRVPromotionItem.PromotionItem_StockItemID=" + lID + " AND GRVPromotionItem.PromotionItem_Quantity=" + Strings.Split(lvPromotion.FocusedItem.Name, "_")[1] + ";");
					loadItems();
				}
			}

		}

		private void cmdPrint_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			update_Renamed();
			modApplication.report_PromotionGRV();
		}

		private void frmGRVPromotion_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			txtFields.AddRange(new TextBox[] { _txtFields_0 });
			DTFields.AddRange(new DateTimePicker[] {
				_DTFields_0,
				_DTFields_1,
				_DTFields_2,
				_DTFields_3
			});
			chkFields.AddRange(new CheckBox[] {
				_chkFields_0,
				_chkFields_1,
				_chkFields_2
			});
			TextBox tb = new TextBox();
			CheckBox cb = new CheckBox();
			DateTimePicker dt = new DateTimePicker();
			foreach (TextBox tb_loopVariable in txtFields) {
				tb = tb_loopVariable;
				tb.Enter += txtFields_Enter;
			}
			lvPromotion.Columns.Clear();
			lvPromotion.Columns.Add("", "Stock Item", Convert.ToInt32(sizeConvertors.twipsToPixels(4550, true)));
			lvPromotion.Columns.Add("QTY", Convert.ToInt32(sizeConvertors.twipsToPixels(1, true)), System.Windows.Forms.HorizontalAlignment.Right);
			lvPromotion.Columns.Add("Price", Convert.ToInt32(sizeConvertors.twipsToPixels(1740, true)), System.Windows.Forms.HorizontalAlignment.Right);
		}

		private void loadItems(ref int lID = 0, ref short quantity = 0)
		{
			System.Windows.Forms.ListViewItem listItem = null;
			ADODB.Recordset rs = default(ADODB.Recordset);
			lvPromotion.Items.Clear();
			rs = modRecordSet.getRS(ref "SELECT StockItem.StockItem_Name, GRVPromotionItem.* FROM GRVPromotionItem INNER JOIN StockItem ON GRVPromotionItem.PromotionItem_StockItemID = StockItem.StockItemID Where (((GRVPromotionItem.PromotionItem_PromotionID) = " + adoPrimaryRS.Fields("PromotionID").Value + ")) ORDER BY StockItem.StockItem_Name, GRVPromotionItem.PromotionItem_Quantity;");
			while (!(rs.EOF)) {
				listItem = lvPromotion.Items.Add(rs.Fields("PromotionItem_StockItemID").Value + "_" + rs.Fields("PromotionItem_Quantity").Value, rs.Fields("Stockitem_Name").Value, "");
				//UPGRADE_WARNING: Lower bound of collection listItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				if (listItem.SubItems.Count > 1) {
					listItem.SubItems[1].Text = rs.Fields("PromotionItem_Quantity").Value;
				} else {
					listItem.SubItems.Insert(1, new System.Windows.Forms.ListViewItem.ListViewSubItem(null, rs.Fields("PromotionItem_Quantity").Value));
				}
				//UPGRADE_WARNING: Lower bound of collection listItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				if (listItem.SubItems.Count > 2) {
					listItem.SubItems[2].Text = Strings.FormatNumber(rs.Fields("PromotionItem_Price").Value, 2);
				} else {
					listItem.SubItems.Insert(2, new System.Windows.Forms.ListViewItem.ListViewSubItem(null, Strings.FormatNumber(rs.Fields("PromotionItem_Price").Value, 2)));
				}
				if (rs.Fields("PromotionItem_StockItemID").Value == lID & rs.Fields("PromotionItem_Quantity").Value == quantity)
					listItem.Selected = true;
				rs.moveNext();
			}
		}
//UPGRADE_WARNING: Event frmGRVPromotion.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
		private void frmGRVPromotion_Resize(System.Object eventSender, System.EventArgs eventArgs)
		{
			Button cmdLast = new Button();
			Button cmdNext = new Button();
			Label lblStatus = new Label();
			 // ERROR: Not supported in C#: OnErrorStatement

			lblStatus.Width = sizeConvertors.pixelToTwips(this.Width, true) - 1500;
			cmdNext.Left = lblStatus.Width + 700;
			cmdLast.Left = cmdNext.Left + 340;
		}

		private void frmGRVPromotion_KeyPress(System.Object eventSender, System.Windows.Forms.KeyPressEventArgs eventArgs)
		{
			short KeyAscii = Strings.Asc(eventArgs.KeyChar);
			if (mbEditFlag | mbAddNewFlag)
				goto EventExitSub;

			switch (KeyAscii) {
				case System.Windows.Forms.Keys.Escape:
					KeyAscii = 0;
					adoPrimaryRS.Move(0);

					cmdClose.Focus();
					System.Windows.Forms.Application.DoEvents();
					cmdClose_Click(cmdClose, new System.EventArgs());
					break;
			}
			EventExitSub:
			eventArgs.KeyChar = Strings.Chr(KeyAscii);
			if (KeyAscii == 0) {
				eventArgs.Handled = true;
			}
		}

		private void frmGRVPromotion_FormClosed(System.Object eventSender, System.Windows.Forms.FormClosedEventArgs eventArgs)
		{
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
		}

		private void adoPrimaryRS_MoveComplete(ADODB.EventReasonEnum adReason, ADODB.Error pError, ref ADODB.EventStatusEnum adStatus, ADODB.Recordset pRecordset)
		{
			//This will display the current record position for this recordset
		}

		private void adoPrimaryRS_WillChangeRecord(ADODB.EventReasonEnum adReason, int cRecords, ref ADODB.EventStatusEnum adStatus, ADODB.Recordset pRecordset)
		{
			//This is where you put validation code
			//This event gets called when the following actions occur
			bool bCancel = false;
			switch (adReason) {
				case ADODB.EventReasonEnum.adRsnAddNew:
					break;
				case ADODB.EventReasonEnum.adRsnClose:
					break;
				case ADODB.EventReasonEnum.adRsnDelete:
					break;
				case ADODB.EventReasonEnum.adRsnFirstChange:
					break;
				case ADODB.EventReasonEnum.adRsnMove:
					break;
				case ADODB.EventReasonEnum.adRsnRequery:
					break;
				case ADODB.EventReasonEnum.adRsnResynch:
					break;
				case ADODB.EventReasonEnum.adRsnUndoAddNew:
					break;
				case ADODB.EventReasonEnum.adRsnUndoDelete:
					break;
				case ADODB.EventReasonEnum.adRsnUndoUpdate:
					break;
				case ADODB.EventReasonEnum.adRsnUpdate:
					break;
			}

			if (bCancel)
				adStatus = ADODB.EventStatusEnum.adStatusCancel;
		}
		private void cmdCancel_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			if (mbAddNewFlag) {
				this.Close();
			} else {
				mbEditFlag = false;
				mbAddNewFlag = false;
				adoPrimaryRS.CancelUpdate();
				if (mvBookMark > 0) {
					adoPrimaryRS.Bookmark = mvBookMark;
				} else {
					adoPrimaryRS.MoveFirst();
				}
				mbDataChanged = false;
			}
		}

//UPGRADE_NOTE: update was upgraded to update_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		private bool update_Renamed()
		{
			bool functionReturnValue = false;
			 // ERROR: Not supported in C#: OnErrorStatement

			functionReturnValue = true;
			adoPrimaryRS.UpdateBatch(ADODB.AffectEnum.adAffectAll);
			if (mbAddNewFlag) {
				adoPrimaryRS.MoveLast();
				//move to the new record
			}

			mbEditFlag = false;
			mbAddNewFlag = false;
			mbDataChanged = false;
			return functionReturnValue;
			UpdateErr:

			Interaction.MsgBox(Err().Description);
			functionReturnValue = false;
			return functionReturnValue;
		}

		private void cmdClose_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			cmdClose.Focus();
			System.Windows.Forms.Application.DoEvents();
			if (update_Renamed()) {
				if (chkFields[1].CheckState == 0) {
					modRecordSet.cnnDB.Execute("UPDATE GRVPromotion SET Promotion_StartDate = #" + DTFields[0].Value + "#, Promotion_EndDate = #" + DTFields[1].Value + "#, Promotion_StartTime = #" + DTFields[2].Value + "# ,Promotion_EndTime =#" + DTFields[3].Value + "# WHERE PromotionID = " + p_Prom + ";");
				}
				this.Close();
			}
		}
		private void lvPromotion_DoubleClick(System.Object eventSender, System.EventArgs eventArgs)
		{
			int lID = 0;
			short lQty = 0;
			if (lvPromotion.FocusedItem == null) {
			} else {
				lID = Convert.ToInt32(Strings.Split(lvPromotion.FocusedItem.Name, "_")[0]);
				lQty = Convert.ToInt16(Strings.Split(lvPromotion.FocusedItem.Name, "_")[1]);

				My.MyProject.Forms.frmGRVPromotionItem.loadItem(ref adoPrimaryRS.Fields("PromotionID").Value, ref lID, ref Convert.ToInt16(lQty));
				loadItems(ref lID, ref lQty);
			}
		}

		private void lvPromotion_KeyPress(System.Object eventSender, System.Windows.Forms.KeyPressEventArgs eventArgs)
		{
			short KeyAscii = Strings.Asc(eventArgs.KeyChar);
			if (KeyAscii == 13) {
				lvPromotion_DoubleClick(lvPromotion, new System.EventArgs());
			}
			eventArgs.KeyChar = Strings.Chr(KeyAscii);
			if (KeyAscii == 0) {
				eventArgs.Handled = true;
			}
		}

		private void txtFields_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			TextBox txtBox = new TextBox();
			txtBox = (TextBox)eventSender;
			int Index = GetIndex.GetIndexer(ref txtBox, ref txtFields);
			modUtilities.MyGotFocus(ref txtFields[Index]);
		}

		private void txtInteger_MyGotFocus(ref short Index)
		{
			//    MyGotFocusNumeric txtInteger(Index)
		}

		private void txtInteger_KeyPress(ref short Index, ref short KeyAscii)
		{
			//    KeyPress KeyAscii
		}

		private void txtInteger_MyLostFocus(ref short Index)
		{
			//    LostFocus txtInteger(Index), 0
		}

		private void txtFloat_MyGotFocus(ref short Index)
		{
			//    MyGotFocusNumeric txtFloat(Index)
		}

		private void txtFloat_KeyPress(ref short Index, ref short KeyAscii)
		{
			//    KeyPress KeyAscii
		}

		private void txtFloat_MyLostFocus(ref short Index)
		{
			//    MyGotFocusNumeric txtFloat(Index), 2
		}

		private void txtFloatNegative_MyGotFocus(ref short Index)
		{
			//    MyGotFocusNumeric txtFloatNegative(Index)
		}

		private void txtFloatNegative_KeyPress(ref short Index, ref short KeyAscii)
		{
			//    KeyPressNegative txtFloatNegative(Index), KeyAscii
		}

		private void txtFloatNegative_MyLostFocus(ref short Index)
		{
			//    LostFocus txtFloatNegative(Index), 2
		}
	}
}
