using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleManager.sections.sorter {
	public class SorterGuiManager : SorterItemData.ItemDataListener {
		private const string NEW_LIST_ITEM = "<New List>";
		private const string UNKNOWN_LIST_NAME = "unknown";

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

		internal void InitGui() {
			UnknownList.Items.Clear();
			foreach (string item in SorterItemData.GetAllUnknown()) {
				UnknownList.Items.Add(item);
			}
			if (UnknownList.Items.Count > 0) {
				UnknownList.SelectedIndex = 0;
			}

			ListnameList.Items.Clear();
			foreach (string listName in SorterItemData.GetAllListNames()) {
				ListnameList.Items.Add(listName);
			}
			ListnameList.Items.Add(NEW_LIST_ITEM);
			ListnameList.SelectedIndex = 0;

			ItemList.Items.Clear();
			if ((string)ListnameList.SelectedItem != NEW_LIST_ITEM) {
				foreach (string itemId in SorterItemData.GetAllItemsForList((string)ListnameList.SelectedItem)) {
					ItemList.Items.Add(itemId);
				}
			}
			if (ItemList.Items.Count > 0) {
				ItemList.SelectedIndex = 0;
			}

		}

		internal void InitEvents() {
			AddItemButton.Click += addItemButton_Click;
			RemoveItemButton.Click += removeItemButton_Click;
			ListnameList.SelectedIndexChanged += listnameList_SelectedIndexChanged;
		}

		private void listnameList_SelectedIndexChanged(object sender, EventArgs e) {
			ItemList.Items.Clear();
			if ((string)ListnameList.SelectedItem != NEW_LIST_ITEM) {
				foreach (string itemId in SorterItemData.GetAllItemsForList((string)ListnameList.SelectedItem)) {
					ItemList.Items.Add(itemId);
				}
			}
			if (ItemList.Items.Count > 0) {
				ItemList.SelectedIndex = 0;
			}
		}

		private void removeItemButton_Click(object sender, EventArgs e) {
			if (ItemList.SelectedItems.Count == 0) {
				return;
			}
			List<string> temp = new List<string>();
			foreach (string itemId in ItemList.SelectedItems) {
				temp.Add(itemId);
			}
			foreach (string itemId in temp) {
				SorterItemData.RemoveItemFromList(itemId);
			}
		}

		private void addItemButton_Click(object sender, EventArgs e) {
			if (UnknownList.SelectedItems.Count == 0 || ListnameList.SelectedItems.Count == 0) {
				return;
			}
			string listNameToAdd;
			if (((string)ListnameList.SelectedItem).Equals(NEW_LIST_ITEM)) {
				InputBox inputB = new InputBox();

				if (DialogResult.OK != inputB.ShowDialog()) {
					return;
				}

				if (SorterItemData.GetAllListNames().Any(listName => listName.Equals(inputB.ListName))) {
					MessageBox.Show("ListName already exists!", "Duplicate ListName", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				listNameToAdd = inputB.ListName;
			} else {
				listNameToAdd = (string)ListnameList.SelectedItem;
			}

			List<string> temp = new List<string>();
			foreach (string itemId in UnknownList.SelectedItems) {
				temp.Add(itemId);
			}
			foreach (string itemId in temp) {
				SorterItemData.AddItemToList(itemId, listNameToAdd);
			}
		}

		public delegate void UpdateUnknownDelegate();
		public delegate void UpdateListNameDelegate();
		public delegate void UpdateItemDelegate();

		public void UpdateItemData() {
			if (UnknownList.InvokeRequired) {
				UpdateUnknownDelegate d = UpdateUnknownList;
				UnknownList.Invoke(d);
			} else {
				UpdateUnknownList();
			}

			if (ListnameList.InvokeRequired) {
				UpdateListNameDelegate d = UpdateListnameList;
				ListnameList.Invoke(d);
			} else {
				UpdateListnameList();
			}

			if (ItemList.InvokeRequired) {
				UpdateItemDelegate d = UpdateItemList;
				ItemList.Invoke(d);
			} else {
				UpdateItemList();
			}
		}



		private void UpdateUnknownList() {
			List<int> indices = new List<int>();

			foreach (int index in UnknownList.SelectedIndices) {
				indices.Add(index);
			}
			UnknownList.Items.Clear();
			foreach (string item in SorterItemData.GetAllUnknown()) {
				UnknownList.Items.Add(item);
			}
			if (indices.Count > 0) {
				foreach (int index in indices) {
					UnknownList.SetSelected(index, true);
				}
			}
		}

		private void UpdateListnameList() {
			List<int> indices = new List<int>();
			foreach (int index in ListnameList.SelectedIndices) {
				indices.Add(index);
			}
			ListnameList.Items.Clear();
			foreach (string listName in SorterItemData.GetAllListNames()) {
				ListnameList.Items.Add(listName);
			}
			ListnameList.Items.Add(NEW_LIST_ITEM);
			if (indices.Count > 0) {
				foreach (int index in indices) {
					ListnameList.SetSelected(index, true);
				}
			} else {
				ListnameList.SetSelected(0, true);
			}
		}

		private void UpdateItemList() {
			List<int> indices = new List<int>();
			foreach (int index in ItemList.SelectedIndices) {
				indices.Add(index);
			}
			ItemList.Items.Clear();
			if ((string)ListnameList.SelectedItem != NEW_LIST_ITEM) {
				foreach (string itemId in SorterItemData.GetAllItemsForList((string)ListnameList.SelectedItem)) {
					ItemList.Items.Add(itemId);
				}
			}
			if (indices.Count > 0) {
				foreach (int index in indices) {
					ItemList.SetSelected(index, true);
				}
			}
		}
	}
}
