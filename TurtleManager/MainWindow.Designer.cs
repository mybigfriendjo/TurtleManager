namespace TurtleManager {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageSorting = new System.Windows.Forms.TabPage();
			this.sorter_tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
			this.sorter_listBoxUnsorted = new System.Windows.Forms.ListBox();
			this.sorter_labelUnsorted = new System.Windows.Forms.Label();
			this.sorter_labelIDLists = new System.Windows.Forms.Label();
			this.sorter_labelItemIDs = new System.Windows.Forms.Label();
			this.sorter_listBoxIDLists = new System.Windows.Forms.ListBox();
			this.sorter_listBoxIDsOnList = new System.Windows.Forms.ListBox();
			this.sorter_buttonAddIDToList = new System.Windows.Forms.Button();
			this.sorter_buttonRemoveIDFromList = new System.Windows.Forms.Button();
			this.sorter_buttonAddIDList = new System.Windows.Forms.Button();
			this.sorter_buttonRemoveIDList = new System.Windows.Forms.Button();
			this.tabControlMain.SuspendLayout();
			this.tabPageSorting.SuspendLayout();
			this.sorter_tableLayoutMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageSorting);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(641, 521);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageSorting
			// 
			this.tabPageSorting.Controls.Add(this.sorter_tableLayoutMain);
			this.tabPageSorting.Location = new System.Drawing.Point(4, 22);
			this.tabPageSorting.Name = "tabPageSorting";
			this.tabPageSorting.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSorting.Size = new System.Drawing.Size(633, 495);
			this.tabPageSorting.TabIndex = 0;
			this.tabPageSorting.Text = "Sorter";
			this.tabPageSorting.UseVisualStyleBackColor = true;
			// 
			// sorter_tableLayoutMain
			// 
			this.sorter_tableLayoutMain.ColumnCount = 5;
			this.sorter_tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.sorter_tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.sorter_tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.sorter_tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.sorter_tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_listBoxUnsorted, 0, 1);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_labelUnsorted, 0, 0);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_labelIDLists, 2, 0);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_labelItemIDs, 4, 0);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_listBoxIDLists, 2, 1);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_listBoxIDsOnList, 4, 1);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_buttonAddIDToList, 1, 2);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_buttonRemoveIDFromList, 1, 3);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_buttonAddIDList, 3, 2);
			this.sorter_tableLayoutMain.Controls.Add(this.sorter_buttonRemoveIDList, 3, 3);
			this.sorter_tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_tableLayoutMain.Location = new System.Drawing.Point(3, 3);
			this.sorter_tableLayoutMain.Name = "sorter_tableLayoutMain";
			this.sorter_tableLayoutMain.RowCount = 5;
			this.sorter_tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.sorter_tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.sorter_tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.sorter_tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.sorter_tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.sorter_tableLayoutMain.Size = new System.Drawing.Size(627, 489);
			this.sorter_tableLayoutMain.TabIndex = 0;
			// 
			// sorter_listBoxUnsorted
			// 
			this.sorter_listBoxUnsorted.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_listBoxUnsorted.FormattingEnabled = true;
			this.sorter_listBoxUnsorted.Location = new System.Drawing.Point(3, 28);
			this.sorter_listBoxUnsorted.Name = "sorter_listBoxUnsorted";
			this.sorter_tableLayoutMain.SetRowSpan(this.sorter_listBoxUnsorted, 4);
			this.sorter_listBoxUnsorted.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.sorter_listBoxUnsorted.Size = new System.Drawing.Size(169, 458);
			this.sorter_listBoxUnsorted.TabIndex = 0;
			// 
			// sorter_labelUnsorted
			// 
			this.sorter_labelUnsorted.AutoSize = true;
			this.sorter_labelUnsorted.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_labelUnsorted.Location = new System.Drawing.Point(3, 0);
			this.sorter_labelUnsorted.Name = "sorter_labelUnsorted";
			this.sorter_labelUnsorted.Size = new System.Drawing.Size(169, 25);
			this.sorter_labelUnsorted.TabIndex = 1;
			this.sorter_labelUnsorted.Text = "Unsorted IDs:";
			this.sorter_labelUnsorted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sorter_labelIDLists
			// 
			this.sorter_labelIDLists.AutoSize = true;
			this.sorter_labelIDLists.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_labelIDLists.Location = new System.Drawing.Point(228, 0);
			this.sorter_labelIDLists.Name = "sorter_labelIDLists";
			this.sorter_labelIDLists.Size = new System.Drawing.Size(169, 25);
			this.sorter_labelIDLists.TabIndex = 2;
			this.sorter_labelIDLists.Text = "ID Lists:";
			this.sorter_labelIDLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sorter_labelItemIDs
			// 
			this.sorter_labelItemIDs.AutoSize = true;
			this.sorter_labelItemIDs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_labelItemIDs.Location = new System.Drawing.Point(453, 0);
			this.sorter_labelItemIDs.Name = "sorter_labelItemIDs";
			this.sorter_labelItemIDs.Size = new System.Drawing.Size(171, 25);
			this.sorter_labelItemIDs.TabIndex = 3;
			this.sorter_labelItemIDs.Text = "IDs on List:";
			this.sorter_labelItemIDs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sorter_listBoxIDLists
			// 
			this.sorter_listBoxIDLists.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_listBoxIDLists.FormattingEnabled = true;
			this.sorter_listBoxIDLists.Location = new System.Drawing.Point(228, 28);
			this.sorter_listBoxIDLists.Name = "sorter_listBoxIDLists";
			this.sorter_tableLayoutMain.SetRowSpan(this.sorter_listBoxIDLists, 4);
			this.sorter_listBoxIDLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.sorter_listBoxIDLists.Size = new System.Drawing.Size(169, 458);
			this.sorter_listBoxIDLists.TabIndex = 4;
			// 
			// sorter_listBoxIDsOnList
			// 
			this.sorter_listBoxIDsOnList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_listBoxIDsOnList.FormattingEnabled = true;
			this.sorter_listBoxIDsOnList.Location = new System.Drawing.Point(453, 28);
			this.sorter_listBoxIDsOnList.Name = "sorter_listBoxIDsOnList";
			this.sorter_tableLayoutMain.SetRowSpan(this.sorter_listBoxIDsOnList, 4);
			this.sorter_listBoxIDsOnList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.sorter_listBoxIDsOnList.Size = new System.Drawing.Size(171, 458);
			this.sorter_listBoxIDsOnList.TabIndex = 5;
			// 
			// sorter_buttonAddIDToList
			// 
			this.sorter_buttonAddIDToList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_buttonAddIDToList.Location = new System.Drawing.Point(178, 210);
			this.sorter_buttonAddIDToList.Name = "sorter_buttonAddIDToList";
			this.sorter_buttonAddIDToList.Size = new System.Drawing.Size(44, 44);
			this.sorter_buttonAddIDToList.TabIndex = 6;
			this.sorter_buttonAddIDToList.Text = ">";
			this.sorter_buttonAddIDToList.UseVisualStyleBackColor = true;
			// 
			// sorter_buttonRemoveIDFromList
			// 
			this.sorter_buttonRemoveIDFromList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_buttonRemoveIDFromList.Location = new System.Drawing.Point(178, 260);
			this.sorter_buttonRemoveIDFromList.Name = "sorter_buttonRemoveIDFromList";
			this.sorter_buttonRemoveIDFromList.Size = new System.Drawing.Size(44, 44);
			this.sorter_buttonRemoveIDFromList.TabIndex = 7;
			this.sorter_buttonRemoveIDFromList.Text = "<";
			this.sorter_buttonRemoveIDFromList.UseVisualStyleBackColor = true;
			// 
			// sorter_buttonAddIDList
			// 
			this.sorter_buttonAddIDList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_buttonAddIDList.Location = new System.Drawing.Point(403, 210);
			this.sorter_buttonAddIDList.Name = "sorter_buttonAddIDList";
			this.sorter_buttonAddIDList.Size = new System.Drawing.Size(44, 44);
			this.sorter_buttonAddIDList.TabIndex = 8;
			this.sorter_buttonAddIDList.Text = "+";
			this.sorter_buttonAddIDList.UseVisualStyleBackColor = true;
			// 
			// sorter_buttonRemoveIDList
			// 
			this.sorter_buttonRemoveIDList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sorter_buttonRemoveIDList.Location = new System.Drawing.Point(403, 260);
			this.sorter_buttonRemoveIDList.Name = "sorter_buttonRemoveIDList";
			this.sorter_buttonRemoveIDList.Size = new System.Drawing.Size(44, 44);
			this.sorter_buttonRemoveIDList.TabIndex = 9;
			this.sorter_buttonRemoveIDList.Text = "-";
			this.sorter_buttonRemoveIDList.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 521);
			this.Controls.Add(this.tabControlMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "TurtleManager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageSorting.ResumeLayout(false);
			this.sorter_tableLayoutMain.ResumeLayout(false);
			this.sorter_tableLayoutMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageSorting;
		private System.Windows.Forms.TableLayoutPanel sorter_tableLayoutMain;
		private System.Windows.Forms.ListBox sorter_listBoxUnsorted;
		private System.Windows.Forms.Label sorter_labelUnsorted;
		private System.Windows.Forms.Label sorter_labelIDLists;
		private System.Windows.Forms.Label sorter_labelItemIDs;
		private System.Windows.Forms.ListBox sorter_listBoxIDLists;
		private System.Windows.Forms.ListBox sorter_listBoxIDsOnList;
		private System.Windows.Forms.Button sorter_buttonAddIDToList;
		private System.Windows.Forms.Button sorter_buttonRemoveIDFromList;
		private System.Windows.Forms.Button sorter_buttonAddIDList;
		private System.Windows.Forms.Button sorter_buttonRemoveIDList;
	}
}

