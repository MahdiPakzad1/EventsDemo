using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages;

public partial class Vote
{

    //variables
    private string primaryButtonIcon = "thumb-up";
    private string dangerButtonIcon = "thumb-down";
    private string resetButtonIcon = "";

    private string primaryButtonText = "Approve";
    private string dangerButtonText = "Reject";
    private string resetButtonText = "";

    // properties
    [Parameter]
    public string? PrimaryButtonIcon { get; set; }

    [Parameter]
    public string? DangerButtonIcon { get; set; }

    [Parameter]
    public string? ResetButtonIcon { get; set; }

    [Parameter]
    public string? PrimaryButtonText { get; set; }

    [Parameter]
    public string? DangerButtonText { get; set; }

    [Parameter]
    public string? ResetButtonText { get; set; }


    [Parameter]
    public EventCallback<string> OnVote { get; set; }

    private void ThumbsUp()
    {
        OnVote.InvokeAsync("Approved");
    }
    private void ThumbsDown()
    {
        OnVote.InvokeAsync("Rejected");
    }
    private void ResetUI()
    {
        OnVote.InvokeAsync("ResetUI");
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        #region ChangeButtonIcon

        if (string.IsNullOrWhiteSpace(PrimaryButtonIcon) == false)
        {
            primaryButtonIcon = PrimaryButtonIcon;

        }
        if (string.IsNullOrWhiteSpace(DangerButtonIcon) == false)
        {
            dangerButtonIcon = DangerButtonIcon;

        }
        if (string.IsNullOrWhiteSpace(ResetButtonIcon) == false)
        {
            resetButtonIcon = ResetButtonIcon;

        }

        #endregion

        #region ChangeButtonText
        if (string.IsNullOrWhiteSpace(PrimaryButtonText) == false)
        {
            primaryButtonText = PrimaryButtonText;

        }
        if (string.IsNullOrWhiteSpace(DangerButtonText) == false)
        {
            dangerButtonText = DangerButtonText;

        }
        if (string.IsNullOrWhiteSpace(ResetButtonText) == false)
        {
            resetButtonText = ResetButtonText;

        }
        #endregion
    }

}
