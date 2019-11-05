namespace ToolsQA.PO.Pages.Datepicker
{
    using NUnit.Framework;

    public partial class DatepickerPage
    {
        public void AssertThat_FormateDateOptions_Change_DateInputFieldValueTo_ProperFormat(int position)
        {
            Assert.That(this.DateFormat.Contains(this.DateOptions[position]));
            Assert.AreEqual(this.DateFormat, this.DateOptions[position]);
        }
    }
}
