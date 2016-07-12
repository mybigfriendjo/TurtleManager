namespace TurtleManager {
	partial class InputBox {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
			this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
			this.labelGroupName = new System.Windows.Forms.Label();
			this.textGroupName = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.tableLayoutMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutMain
			// 
			this.tableLayoutMain.ColumnCount = 2;
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutMain.Controls.Add(this.labelGroupName, 0, 0);
			this.tableLayoutMain.Controls.Add(this.textGroupName, 0, 1);
			this.tableLayoutMain.Controls.Add(this.buttonOK, 0, 2);
			this.tableLayoutMain.Controls.Add(this.buttonCancel, 1, 2);
			this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutMain.Name = "tableLayoutMain";
			this.tableLayoutMain.RowCount = 3;
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMain.Size = new System.Drawing.Size(379, 99);
			this.tableLayoutMain.TabIndex = 0;
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelGroupName.Location = new System.Drawing.Point(3, 0);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(183, 25);
			this.labelGroupName.TabIndex = 0;
			this.labelGroupName.Text = "Input new Group Name:";
			this.labelGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textGroupName
			// 
			this.tableLayoutMain.SetColumnSpan(this.textGroupName, 2);
			this.textGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textGroupName.Location = new System.Drawing.Point(3, 28);
			this.textGroupName.Name = "textGroupName";
			this.textGroupName.Size = new System.Drawing.Size(373, 20);
			this.textGroupName.TabIndex = 1;
			// 
			// buttonOK
			// 
			this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOK.Location = new System.Drawing.Point(3, 53);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(183, 43);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCancel.Location = new System.Drawing.Point(192, 53);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(184, 43);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// InputBox
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 99);
			this.Controls.Add(this.tableLayoutMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.tableLayoutMain.ResumeLayout(false);
			this.tableLayoutMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.TextBox textGroupName;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}