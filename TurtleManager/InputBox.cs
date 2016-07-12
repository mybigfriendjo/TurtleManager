using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleManager {
	public partial class InputBox : Form {

		public InputBox() {
			InitializeComponent();
		}

		public string ListName {
			get;
			private set;
		}

		private void buttonOK_Click(object sender, EventArgs e) {
			//TODO: check for sane GroupNames

			if (string.IsNullOrWhiteSpace(textGroupName.Text)) {
				MessageBox.Show("No Value for Group Name entered!", "Missing Group Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			ListName = textGroupName.Text.Trim();
			DialogResult = DialogResult.OK;
		}

		private void buttonCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
		}
	}
}
