namespace LetsTalk.Core.Common.UI.Controls
{
    using LetsTalk.Core.Common.Contracts.Entities;

    public interface IAddressPickerViewModel
    {
        IAddress SelectedAddress { get; set; }

        string Text { get; }
    }
}