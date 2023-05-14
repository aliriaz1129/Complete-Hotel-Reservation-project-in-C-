// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;
// End of VB project level imports


namespace HBRS
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmCheckin : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckin));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.lblAdvancePayment = new System.Windows.Forms.Label();
            this.bttnAddChildren = new System.Windows.Forms.Button();
            this.bttnAddAdult = new System.Windows.Forms.Button();
            this.bttnSubChildren = new System.Windows.Forms.Button();
            this.bttnSubAdult = new System.Windows.Forms.Button();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.bttnSearchRoom = new System.Windows.Forms.Button();
            this.bttnSearchGuest = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnCheckIn = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtDaysNumber = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.dtCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.Label16 = new System.Windows.Forms.Label();
            this.lvlcheckin = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNoOfOccupancy = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblDiscountID = new System.Windows.Forms.Label();
            this.lblDiscountRate = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(15, 14);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1119, 612);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TabPage1.Controls.Add(this.lblAdvancePayment);
            this.TabPage1.Controls.Add(this.bttnAddChildren);
            this.TabPage1.Controls.Add(this.bttnAddAdult);
            this.TabPage1.Controls.Add(this.bttnSubChildren);
            this.TabPage1.Controls.Add(this.bttnSubAdult);
            this.TabPage1.Controls.Add(this.txtAdults);
            this.TabPage1.Controls.Add(this.txtChildren);
            this.TabPage1.Controls.Add(this.bttnSearchRoom);
            this.TabPage1.Controls.Add(this.bttnSearchGuest);
            this.TabPage1.Controls.Add(this.bttnCancel);
            this.TabPage1.Controls.Add(this.bttnCheckIn);
            this.TabPage1.Controls.Add(this.txtTotal);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Controls.Add(this.txtAdvance);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.cboDiscount);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.Label12);
            this.TabPage1.Controls.Add(this.txtSubTotal);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.txtDaysNumber);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.txtCheckInDate);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.dtCheckOutDate);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.txtRoomRate);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.txtRoomType);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.txtRoomNumber);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.txtGuestName);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.txtTransID);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.ShapeContainer1);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage1.Size = new System.Drawing.Size(1111, 579);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Check In Form";
            // 
            // lblAdvancePayment
            // 
            this.lblAdvancePayment.AutoSize = true;
            this.lblAdvancePayment.ForeColor = System.Drawing.Color.Red;
            this.lblAdvancePayment.Location = new System.Drawing.Point(729, 378);
            this.lblAdvancePayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvancePayment.Name = "lblAdvancePayment";
            this.lblAdvancePayment.Size = new System.Drawing.Size(0, 20);
            this.lblAdvancePayment.TabIndex = 74;
            this.lblAdvancePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnAddChildren
            // 
            this.bttnAddChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddChildren.Location = new System.Drawing.Point(996, 182);
            this.bttnAddChildren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnAddChildren.Name = "bttnAddChildren";
            this.bttnAddChildren.Size = new System.Drawing.Size(34, 38);
            this.bttnAddChildren.TabIndex = 73;
            this.bttnAddChildren.Text = ">";
            this.bttnAddChildren.UseVisualStyleBackColor = true;
            this.bttnAddChildren.Click += new System.EventHandler(this.bttnAddChildren_Click);
            // 
            // bttnAddAdult
            // 
            this.bttnAddAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddAdult.Location = new System.Drawing.Point(996, 135);
            this.bttnAddAdult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnAddAdult.Name = "bttnAddAdult";
            this.bttnAddAdult.Size = new System.Drawing.Size(34, 38);
            this.bttnAddAdult.TabIndex = 72;
            this.bttnAddAdult.Text = ">";
            this.bttnAddAdult.UseVisualStyleBackColor = true;
            this.bttnAddAdult.Click += new System.EventHandler(this.bttnAddAdult_Click);
            // 
            // bttnSubChildren
            // 
            this.bttnSubChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubChildren.Location = new System.Drawing.Point(962, 180);
            this.bttnSubChildren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnSubChildren.Name = "bttnSubChildren";
            this.bttnSubChildren.Size = new System.Drawing.Size(34, 38);
            this.bttnSubChildren.TabIndex = 71;
            this.bttnSubChildren.Text = "<";
            this.bttnSubChildren.UseVisualStyleBackColor = true;
            this.bttnSubChildren.Click += new System.EventHandler(this.bttnSubChildren_Click);
            // 
            // bttnSubAdult
            // 
            this.bttnSubAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubAdult.Location = new System.Drawing.Point(962, 134);
            this.bttnSubAdult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnSubAdult.Name = "bttnSubAdult";
            this.bttnSubAdult.Size = new System.Drawing.Size(34, 38);
            this.bttnSubAdult.TabIndex = 70;
            this.bttnSubAdult.Text = "<";
            this.bttnSubAdult.UseVisualStyleBackColor = true;
            this.bttnSubAdult.Click += new System.EventHandler(this.bttnSubAdult_Click);
            // 
            // txtAdults
            // 
            this.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(872, 135);
            this.txtAdults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdults.Multiline = true;
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.ReadOnly = true;
            this.txtAdults.Size = new System.Drawing.Size(74, 36);
            this.txtAdults.TabIndex = 69;
            this.txtAdults.Text = "0";
            this.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(872, 183);
            this.txtChildren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.ReadOnly = true;
            this.txtChildren.Size = new System.Drawing.Size(74, 36);
            this.txtChildren.TabIndex = 68;
            this.txtChildren.Text = "0";
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnSearchRoom
            // 
            this.bttnSearchRoom.Location = new System.Drawing.Point(420, 189);
            this.bttnSearchRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnSearchRoom.Name = "bttnSearchRoom";
            this.bttnSearchRoom.Size = new System.Drawing.Size(45, 40);
            this.bttnSearchRoom.TabIndex = 67;
            this.bttnSearchRoom.Text = "...";
            this.bttnSearchRoom.UseVisualStyleBackColor = true;
            this.bttnSearchRoom.Click += new System.EventHandler(this.bttnSearchRoom_Click);
            // 
            // bttnSearchGuest
            // 
            this.bttnSearchGuest.Location = new System.Drawing.Point(562, 140);
            this.bttnSearchGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnSearchGuest.Name = "bttnSearchGuest";
            this.bttnSearchGuest.Size = new System.Drawing.Size(45, 40);
            this.bttnSearchGuest.TabIndex = 66;
            this.bttnSearchGuest.Text = "...";
            this.bttnSearchGuest.UseVisualStyleBackColor = true;
            this.bttnSearchGuest.Click += new System.EventHandler(this.bttnSearchGuest_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(884, 478);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(170, 54);
            this.bttnCancel.TabIndex = 65;
            this.bttnCancel.Text = "C&ancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnCheckIn
            // 
            this.bttnCheckIn.Location = new System.Drawing.Point(704, 478);
            this.bttnCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnCheckIn.Name = "bttnCheckIn";
            this.bttnCheckIn.Size = new System.Drawing.Size(170, 54);
            this.bttnCheckIn.TabIndex = 64;
            this.bttnCheckIn.Text = "&Check In";
            this.bttnCheckIn.UseVisualStyleBackColor = true;
            this.bttnCheckIn.Click += new System.EventHandler(this.bttnCheckIn_Click_1);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(873, 414);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(178, 36);
            this.txtTotal.TabIndex = 53;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(674, 418);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(132, 25);
            this.Label15.TabIndex = 63;
            this.Label15.Text = "Total Balance";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(873, 329);
            this.txtAdvance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdvance.Multiline = true;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(178, 36);
            this.txtAdvance.TabIndex = 52;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdvance.TextChanged += new System.EventHandler(this.txtAdvance_TextChanged);
            this.txtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvance_KeyPress);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(674, 334);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(172, 25);
            this.Label14.TabIndex = 62;
            this.Label14.Text = "Advance Payment";
            // 
            // cboDiscount
            // 
            this.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(873, 237);
            this.cboDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(176, 28);
            this.cboDiscount.TabIndex = 51;
            this.cboDiscount.SelectedIndexChanged += new System.EventHandler(this.cboDiscount_SelectedIndexChanged);
            this.cboDiscount.TextChanged += new System.EventHandler(this.cboDiscount_TextChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(674, 238);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(138, 25);
            this.Label13.TabIndex = 61;
            this.Label13.Text = "Discount Type";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(674, 186);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(146, 25);
            this.Label12.TabIndex = 60;
            this.Label12.Text = "No. Of Children";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(873, 280);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(178, 36);
            this.txtSubTotal.TabIndex = 49;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(674, 285);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(97, 25);
            this.Label11.TabIndex = 59;
            this.Label11.Text = "Sub Total";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(674, 140);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(128, 25);
            this.Label10.TabIndex = 58;
            this.Label10.Text = "No. Of Adults";
            // 
            // txtDaysNumber
            // 
            this.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDaysNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysNumber.Location = new System.Drawing.Point(238, 422);
            this.txtDaysNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDaysNumber.Multiline = true;
            this.txtDaysNumber.Name = "txtDaysNumber";
            this.txtDaysNumber.ReadOnly = true;
            this.txtDaysNumber.Size = new System.Drawing.Size(170, 36);
            this.txtDaysNumber.TabIndex = 44;
            this.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(57, 428);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(118, 25);
            this.Label9.TabIndex = 57;
            this.Label9.Text = "No. Of Days";
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.BackColor = System.Drawing.Color.White;
            this.txtCheckInDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate.Location = new System.Drawing.Point(238, 331);
            this.txtCheckInDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckInDate.Multiline = true;
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.ReadOnly = true;
            this.txtCheckInDate.Size = new System.Drawing.Size(172, 38);
            this.txtCheckInDate.TabIndex = 56;
            this.txtCheckInDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(57, 337);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(136, 25);
            this.Label8.TabIndex = 55;
            this.Label8.Text = "Check In Date";
            // 
            // dtCheckOutDate
            // 
            this.dtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOutDate.Location = new System.Drawing.Point(238, 378);
            this.dtCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtCheckOutDate.Name = "dtCheckOutDate";
            this.dtCheckOutDate.Size = new System.Drawing.Size(170, 30);
            this.dtCheckOutDate.TabIndex = 43;
            this.dtCheckOutDate.ValueChanged += new System.EventHandler(this.dtCheckOutDate_ValueChanged_1);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(57, 382);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(152, 25);
            this.Label7.TabIndex = 54;
            this.Label7.Text = "Check Out Date";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRate.Location = new System.Drawing.Point(238, 285);
            this.txtRoomRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.ReadOnly = true;
            this.txtRoomRate.Size = new System.Drawing.Size(170, 36);
            this.txtRoomRate.TabIndex = 42;
            this.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoomRate.TextChanged += new System.EventHandler(this.txtRoomRate_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(57, 292);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(108, 25);
            this.Label6.TabIndex = 50;
            this.Label6.Text = "Room Rate";
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(238, 237);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(313, 36);
            this.txtRoomType.TabIndex = 40;
            this.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(57, 245);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(113, 25);
            this.Label5.TabIndex = 47;
            this.Label5.Text = "Room Type";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(238, 189);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.Size = new System.Drawing.Size(170, 36);
            this.txtRoomNumber.TabIndex = 38;
            this.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(57, 197);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(137, 25);
            this.Label4.TabIndex = 45;
            this.Label4.Text = "Room Number";
            // 
            // txtGuestName
            // 
            this.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(238, 142);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(313, 36);
            this.txtGuestName.TabIndex = 35;
            this.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(57, 149);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(121, 25);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Guest Name";
            // 
            // txtTransID
            // 
            this.txtTransID.BackColor = System.Drawing.Color.White;
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransID.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTransID.Location = new System.Drawing.Point(238, 94);
            this.txtTransID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransID.Multiline = true;
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.ReadOnly = true;
            this.txtTransID.Size = new System.Drawing.Size(172, 38);
            this.txtTransID.TabIndex = 39;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(57, 102);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(139, 25);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Transaction ID";
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(220, 33);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Check In Form";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(4, 5);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LineShape1});
            this.ShapeContainer1.Size = new System.Drawing.Size(1103, 569);
            this.ShapeContainer1.TabIndex = 75;
            this.ShapeContainer1.TabStop = false;
            // 
            // LineShape1
            // 
            this.LineShape1.BorderColor = System.Drawing.SystemColors.MenuText;
            this.LineShape1.Name = "LineShape1";
            this.LineShape1.X1 = 11;
            this.LineShape1.X2 = 715;
            this.LineShape1.Y1 = 46;
            this.LineShape1.Y2 = 46;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.dtOut);
            this.TabPage2.Controls.Add(this.dtIn);
            this.TabPage2.Controls.Add(this.Label16);
            this.TabPage2.Controls.Add(this.lvlcheckin);
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage2.Size = new System.Drawing.Size(1111, 579);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Check In List";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // dtOut
            // 
            this.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOut.Location = new System.Drawing.Point(172, 514);
            this.dtOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(154, 26);
            this.dtOut.TabIndex = 39;
            this.dtOut.Visible = false;
            // 
            // dtIn
            // 
            this.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIn.Location = new System.Drawing.Point(22, 514);
            this.dtIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(139, 26);
            this.dtIn.TabIndex = 38;
            this.dtIn.Visible = false;
            // 
            // Label16
            // 
            this.Label16.AutoEllipsis = true;
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(15, 37);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(197, 33);
            this.Label16.TabIndex = 37;
            this.Label16.Text = "Check In List";
            // 
            // lvlcheckin
            // 
            this.lvlcheckin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10,
            this.ColumnHeader11});
            this.lvlcheckin.FullRowSelect = true;
            this.lvlcheckin.GridLines = true;
            this.lvlcheckin.HideSelection = false;
            this.lvlcheckin.Location = new System.Drawing.Point(18, 78);
            this.lvlcheckin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvlcheckin.Name = "lvlcheckin";
            this.lvlcheckin.Size = new System.Drawing.Size(1066, 413);
            this.lvlcheckin.TabIndex = 0;
            this.lvlcheckin.UseCompatibleStateImageBehavior = false;
            this.lvlcheckin.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "TransID";
            this.ColumnHeader1.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Guest Name";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 200;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Room #";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Checkin Date";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 100;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Checkout Date";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 100;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "No. of Days";
            this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader6.Width = 80;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Children";
            this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Adults";
            this.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Advance Payment";
            this.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader9.Width = 120;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "Discount";
            this.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader10.Width = 80;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Total";
            this.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader11.Width = 80;
            // 
            // lblNoOfOccupancy
            // 
            this.lblNoOfOccupancy.AutoSize = true;
            this.lblNoOfOccupancy.Location = new System.Drawing.Point(10, 720);
            this.lblNoOfOccupancy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfOccupancy.Name = "lblNoOfOccupancy";
            this.lblNoOfOccupancy.Size = new System.Drawing.Size(125, 20);
            this.lblNoOfOccupancy.TabIndex = 1;
            this.lblNoOfOccupancy.Text = "NoOfOccupancy";
            this.lblNoOfOccupancy.Visible = false;
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(10, 686);
            this.lblGuestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(70, 20);
            this.lblGuestID.TabIndex = 2;
            this.lblGuestID.Text = "GuestID";
            this.lblGuestID.Visible = false;
            // 
            // lblDiscountID
            // 
            this.lblDiscountID.AutoSize = true;
            this.lblDiscountID.Location = new System.Drawing.Point(10, 757);
            this.lblDiscountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountID.Name = "lblDiscountID";
            this.lblDiscountID.Size = new System.Drawing.Size(89, 20);
            this.lblDiscountID.TabIndex = 3;
            this.lblDiscountID.Text = "DiscountID";
            this.lblDiscountID.Visible = false;
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Location = new System.Drawing.Point(219, 686);
            this.lblDiscountRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(107, 20);
            this.lblDiscountRate.TabIndex = 4;
            this.lblDiscountRate.Text = "DiscountRate";
            this.lblDiscountRate.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(230, 722);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 651);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountRate);
            this.Controls.Add(this.lblDiscountID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblNoOfOccupancy);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckin_FormClosing);
            this.Load += new System.EventHandler(this.frmCheckin_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Button bttnSearchRoom;
		internal System.Windows.Forms.Button bttnSearchGuest;
		internal System.Windows.Forms.Button bttnCancel;
		internal System.Windows.Forms.Button bttnCheckIn;
		internal System.Windows.Forms.TextBox txtTotal;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtAdvance;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.ComboBox cboDiscount;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtSubTotal;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtDaysNumber;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtCheckInDate;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.DateTimePicker dtCheckOutDate;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtRoomRate;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtRoomType;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtRoomNumber;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtGuestName;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtTransID;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.ListView lvlcheckin;
		internal System.Windows.Forms.Label lblNoOfOccupancy;
		internal System.Windows.Forms.Label lblGuestID;
		internal System.Windows.Forms.TextBox txtAdults;
		internal System.Windows.Forms.TextBox txtChildren;
		internal System.Windows.Forms.Button bttnSubChildren;
		internal System.Windows.Forms.Button bttnSubAdult;
		internal System.Windows.Forms.Button bttnAddChildren;
		internal System.Windows.Forms.Button bttnAddAdult;
		internal System.Windows.Forms.Label lblDiscountID;
		internal System.Windows.Forms.Label lblDiscountRate;
		internal System.Windows.Forms.Label lblAdvancePayment;
		internal System.Windows.Forms.Label lblTotal;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.DateTimePicker dtOut;
		internal System.Windows.Forms.DateTimePicker dtIn;
		internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
	}
	
}
