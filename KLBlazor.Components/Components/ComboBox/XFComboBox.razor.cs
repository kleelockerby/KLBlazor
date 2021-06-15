using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace KLBlazor.Components
{
    public partial class XFComboBox<TItem> : XFListBoxBase<TItem>
    {
        [Parameter] public string PlaceHolder { get; set; }
        [Parameter] public bool AllowClear { get; set; } = false;
        [Parameter] public RenderFragment<TItem> ItemTemplate { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        protected ClassBuilder ContentClassBuilder { get; private set; }
        protected string ContentClassNames => ContentClassBuilder.Class;

        protected ClassBuilder ListBoxClassBuilder { get; private set; }
        protected string ListBoxClassNames => ListBoxClassBuilder.Class;

        protected ClassBuilder ULClassBuilder { get; private set; }
        protected string ULClassNames => ULClassBuilder.Class;

        protected bool PreventDefault { get; private set; }
        protected bool StopPropogation { get; private set; }

        public XFComboBox()
        {
            ContentClassBuilder = new ClassBuilder(BuildContentClasses);
            ListBoxClassBuilder = new ClassBuilder(BuildListBoxClasses);
            ULClassBuilder = new ClassBuilder(BuildULClasses);
        }

        protected override void BuildClasses(ClassBuilder builder)
        {
            builder.Append("xf-combo");
            base.BuildClasses(builder);
        }

        private void BuildContentClasses(ClassBuilder builder)
        {
            builder.Append("xf-combo-wrapper");
        }

        private void BuildListBoxClasses(ClassBuilder builder)
        {
            builder.Append("xf-scrollbox");
            builder.Append("show", visible);
        }

        private void BuildULClasses(ClassBuilder builder)
        {
            builder.Append("xf-listbox");
        }

        protected void XFLink_Clicked()
        {
            this.Toggle();
        }

        protected void TextBox_InputChanged(string newChar)
        {
            if (!this.AllowFiltering)
                return;
            this.SelectedChars = newChar;
            this.FilterData(this.Query);
            StateHasChanged();
        }

        protected void TextBox_ValueChanged(string newText)
        {
            if (this.AllowTextEntry == false)
                return;
            this.SelectedText = newText;
            StateHasChanged();
        }

        protected void XFTextBox_Clicked()
        {
            this.Show();
        }

        protected void BtnClose_Clicked()
        {
            this.Clear();
            this.Hide();
            StateHasChanged();
        }

        protected void Clear()
        {
            this.SelectedText = string.Empty;
            this.SelectedValue = null;

            if (this.SelectedListBoxItem != null)
            {
                this.SelectedListBoxItem.SetSelection(false);
            }
        }
    }
}
