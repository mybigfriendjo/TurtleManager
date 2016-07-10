using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleManager.sections.sorter {
	public class SorterGuiManager : SorterItemData.ItemDataListener {
		public ListBox ItemList {
			get;
			internal set;
		}
		public ListBox ListnameList {
			get;
			internal set;
		}
		public ListBox UnknownList {
			get;
			internal set;
		}
		public Button AddItemButton {
			get;
			internal set;
		}
		public Button RemoveItemButton {
			get;
			internal set;
		}
		public Button RemoveListButton {
			get;
			internal set;
		}
		public Button AddListButton {
			get;
			internal set;
		}

		internal void InitEvents() {
			AddListButton.Click += addListButton_Click;
			RemoveListButton.Click += removeListButton_Click;

			AddItemButton.Click += addItemButton_Click;
			RemoveItemButton.Click += removeItemButton_Click;
		}

		private void removeItemButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException(); //TODO:
		}

		private void addItemButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException(); //TODO:
		}

		private void removeListButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException(); //TODO:
		}

		private void addListButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException(); //TODO:
		}

		public void UpdateItemData() {
			throw new NotImplementedException(); //TODO:
		}
	}
}
