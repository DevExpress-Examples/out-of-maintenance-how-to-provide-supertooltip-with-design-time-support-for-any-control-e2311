using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.Utils;
using System.Drawing.Design;
using System.Collections;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace E2311
{
    public class MyNavBarSuperToolTipItemsCollection : CollectionBase
    {
        int lockUpdate;
        Hashtable indexes;
        public event CollectionChangeEventHandler CollectionChanged;
        public MyNavBarSuperToolTipItemsCollection()
        {
            this.indexes = new Hashtable();
            this.lockUpdate = 0;
        }


        protected virtual IComparer CreateComparer()
        {
            return new DevExpress.Data.ValueComparer();
        }

        [Description("Gets or sets an item at the specified position.")]
        public MyNavBarSuperToolTipHelperItem this[int index]
        {
            get { return List[index] as MyNavBarSuperToolTipHelperItem; }
            set
            {
                List[index] = value;
            }
        }
        protected virtual Hashtable Indexes { get { return indexes; } }
        public virtual void BeginUpdate()
        {
            lockUpdate++;
        }
        public virtual void EndUpdate()
        {
            if (--lockUpdate == 0)
            {
                RaiseCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null));
            }
        }

        public virtual int Add(MyNavBarSuperToolTipHelperItem item)
        {
            return List.Add(item);
        }
        public virtual void AddRange(ICollection collection)
        {
            BeginUpdate();
            try
            {
                foreach (object item in collection) Add(item as MyNavBarSuperToolTipHelperItem);
            }
            finally
            {
                EndUpdate();
            }
        }
        public virtual void AddRange(MyNavBarSuperToolTipHelperItem[] items)
        {
            BeginUpdate();
            try
            {
                foreach (MyNavBarSuperToolTipHelperItem item in items) Add(item);
            }
            finally
            {
                EndUpdate();
            }
        }
        public virtual void Remove(MyNavBarSuperToolTipHelperItem item) { List.Remove(item); }
        public virtual void Insert(int index, MyNavBarSuperToolTipHelperItem item)
        {
            List.Insert(index, item);
        }
        public virtual int IndexOf(MyNavBarSuperToolTipHelperItem item)
        {
            if (item != null && Indexes.Contains(item))
            {
                return (int)Indexes[item];
            }
            int i = List.IndexOf(item);
            if (item != null && i > -1) Indexes[item] = i;
            return i;
        }
        public virtual bool Contains(MyNavBarSuperToolTipHelperItem item)
        {
            return IndexOf(item) != -1;
        }
        protected virtual bool CanAddItem(object item) { return true; }


        protected bool IsLockUpdate { get { return this.lockUpdate != 0; } }
        protected virtual void RaiseCollectionChanged(CollectionChangeEventArgs e)
        {
            if (IsLockUpdate) return;
            if (CollectionChanged != null) CollectionChanged(this, e);
        }
    }
}
