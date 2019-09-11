﻿using System;
using System.Windows.Input;
using MyCart.Models.Ecommerce;
using Syncfusion.XForms.ComboBox;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MyCart.Behaviors.Ecommerce
{
    /// <summary>
    /// This class extends the behavior of the SfComboBox control to invoke a command when an event occurs.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class DropDownBehavior : Behavior<SfComboBox>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CommandProperty, and it is a bindable property.
        /// </summary>
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(DropDownBehavior));

        /// <summary>
        /// Gets or sets the Command.
        /// </summary>
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        /// <summary>
        /// Gets the comboBox.
        /// </summary>
        public SfComboBox ComboBox { get; private set; }

        private bool isCheckboxLoaded;

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when adding comboBox to view.
        /// </summary>
        /// <param name="comboBox">The ComboBox</param>
        protected override void OnAttachedTo(SfComboBox comboBox)
        {
            base.OnAttachedTo(comboBox);
            this.ComboBox = comboBox;
            comboBox.BindingContextChanged += this.OnBindingContextChanged;
            comboBox.SelectionChanged += this.SelectionChanged;
        }

        /// <summary>
        /// Invoked when exit from the view.
        /// </summary>
        /// <param name="comboBox">The comboBox</param>
        protected override void OnDetachingFrom(SfComboBox comboBox)
        {
            base.OnDetachingFrom(comboBox);
            comboBox.BindingContextChanged -= this.OnBindingContextChanged;
            comboBox.SelectionChanged -= this.SelectionChanged;
            this.ComboBox = null;
        }

        /// <summary>
        /// Invoked when comboBox binding context is changed.
        /// </summary>
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            this.BindingContext = this.ComboBox.BindingContext;
        }

        /// <summary>
        /// Invoked when selected item is changed.
        /// </summary>
        /// <param name="sender">The comboBox</param>
        /// <param name="e">The selection changed event args</param>
        private void SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {
            int totalQuantity;
            int.TryParse(e.Value.ToString(), out totalQuantity);
            ((sender as SfComboBox).BindingContext as Product).TotalQuantity = totalQuantity;

            if (isCheckboxLoaded)
            {
                if (this.Command == null)
                    return;

                if (this.Command.CanExecute(((sender as SfComboBox).BindingContext as Product)))
                    this.Command.Execute(((sender as SfComboBox).BindingContext as Product));
            }

            isCheckboxLoaded = true;
        }

        /// <summary>
        /// Invoked when binding context is changed.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            this.OnBindingContextChanged();
        }

        #endregion
    }
}