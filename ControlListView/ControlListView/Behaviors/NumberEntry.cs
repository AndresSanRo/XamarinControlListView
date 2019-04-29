using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ControlListView.Behaviors
{
    public class NumberEntry : Behavior<Entry>
    {
        private String ValidText;
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += Bindable_TextChanged;
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged += Bindable_TextChanged1;
            base.OnDetachingFrom(bindable);
        }

        private void Bindable_TextChanged1(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry box = sender as Entry;
            if (box != null)
            {
                try
                {
                    int value = int.Parse(box.Text);
                    ValidText = value.ToString();
                }
                catch (Exception ex)
                {
                    box.Text = ValidText;
                }
            }            
        }
    }
}
