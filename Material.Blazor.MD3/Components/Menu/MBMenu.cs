using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

public class MBMenu : ComponentFoundation
{
    #region members

    /// <summary>
    /// The location of the icon on the button used to invoke the menu.
    /// </summary>
    [Parameter] public bool ButtonIconIsTrailing { get; set; }

    /// <summary>
    /// The style of the button used to invoke the menu.
    /// </summary>
    [Parameter] public MBButtonStyle? ButtonStyle { get; set; }

    /// <summary>
    /// The label of the button used to invoke the menu.
    /// </summary>
    [Parameter] public string ButtonLabel { get; set; }

    /// <summary>
    /// The label color of the button used to invoke the menu.
    /// </summary>
    [Parameter] public string ButtonLabelColor { get; set; }

    /// <summary>
    /// Sets the menu anchor attribute
    /// </summary>
    [Parameter] public MBMenuAnchorType AnchorType { get; set; } = MBMenuAnchorType.Button;

    /// <summary>
    /// The icon on the button (or standalone) used to invoke the menu.
    /// </summary>
    [Parameter] public MBIconDescriptor IconDescriptor { get; set; }

    /// <summary>
    /// The list of menu items.
    /// </summary>
    [Parameter] public MBMenuItem[] MenuItems { get; set; }

    /// <summary>
    /// Sets the menu positioning attribute
    /// </summary>
    [Parameter] public MBMenuPositioning MenuPositioning { get; set; } = MBMenuPositioning.Relative;



    private string AnchorId { get; } = "menu-button-id-" + Guid.NewGuid().ToString().ToLower();
    private string MenuId { get; set; } = "menu-id-" + Guid.NewGuid().ToString().ToLower();


    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        builder.OpenElement(0, "span");
        {
            builder.AddAttribute(1, "class", @ActiveConditionalClasses + @class);
            builder.AddAttribute(2, "style", @style + " position: relative; ");
            builder.AddAttribute(3, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(4, attributesToSplat);
            }

            if (AnchorType == MBMenuAnchorType.Button)
            {
                builder.OpenComponent(5, typeof(MBButton));
                {
                    builder.AddComponentParameter(6, "Label", ButtonLabel);
                    builder.AddComponentParameter(7, "ButtonStyle", ButtonStyle);
                    builder.AddComponentParameter(8, "IconDescriptor", IconDescriptor);
                    builder.AddComponentParameter(9, "IconIsTrailing", ButtonIconIsTrailing);
                    builder.AddAttribute(10, "id", AnchorId);
                    builder.AddAttribute(11, "style", "color: " + ButtonLabelColor + ";");
                }
                builder.CloseComponent();
            }
            else
            {
                //
                // Type is "Icon", we fake it by doing an IconButton with a style of Icon
                // because adding an "onclick" to a raw icon does not work
                //
                builder.OpenComponent(5, typeof(MBIconButton));
                {
                    builder.AddComponentParameter(6, "ButtonStyle", MBIconButtonStyle.Icon);
                    builder.AddComponentParameter(7, "IconDescriptor", IconDescriptor);
                    builder.AddAttribute(8, "id", AnchorId);
                }
                builder.CloseComponent();
            }

            builder.OpenElement(12, "md-menu");
            {
                builder.AddAttribute(13, "anchor", AnchorId);
                builder.AddAttribute(14, "id", MenuId);
                builder.AddAttribute(15, "positioning", MenuPositioning.ToString().ToLower());

                if (MenuItems is not null)
                {
                    var rendSeq = 20;
                    foreach (var menuItem in MenuItems)
                    {
                        switch (menuItem.MenuItemType)
                        {
                            case MBMenuItemType.BeginSubMenu:
                                break;

                            case MBMenuItemType.Divider:
                                builder.OpenElement(rendSeq + 1, "md-divider");
                                builder.CloseElement();
                                break;

                            case MBMenuItemType.EndSubMenu:
                                break;

                            case MBMenuItemType.Regular:
                            default:
                                builder.OpenElement(rendSeq++, "md-menu-item");
                                {
                                    if (menuItem.IsDisabled)
                                    {
                                        builder.AddAttribute(rendSeq + 1, "disabled");
                                    }

                                    if (menuItem.Headline.Length > 0)
                                    {
                                        builder.AddAttribute(rendSeq + 2, "id", menuItem.Identifier);

                                        builder.OpenElement(rendSeq + 3, "div");
                                        {
                                            if (menuItem.HeadlineColor.Length > 0)
                                            {
                                                builder.AddAttribute(rendSeq + 4, "style", "color: " + menuItem.HeadlineColor + "; ");
                                            }
                                            builder.AddAttribute(rendSeq + 5, "slot", "headline");
                                            builder.AddContent(rendSeq + 6, menuItem.Headline);
                                        }
                                        builder.CloseElement();
                                    }

                                    rendSeq += 10;
                                    if (menuItem.LeadingIcon is not null && !menuItem.SuppressLeadingIcon)
                                    {
                                        MBIcon.BuildRenderTreeWorker(
                                            builder,
                                            ref rendSeq,
                                            CascadingDefaults,
                                            null,
                                            null,
                                            null,
                                            null,
                                            menuItem.LeadingIcon,
                                            "start");
                                    }

                                    rendSeq += 10;
                                    if (menuItem.TrailingIcon is not null)
                                    {
                                        MBIcon.BuildRenderTreeWorker(
                                            builder,
                                            ref rendSeq,
                                            CascadingDefaults,
                                            null,
                                            null,
                                            null,
                                            null,
                                            menuItem.TrailingIcon,
                                            "end");
                                    }
                                }
                                builder.CloseComponent();
                                break;
                        }
                        rendSeq += 100;
                    }
                }
            }
            builder.CloseElement();
            builder.OpenElement(20000, "pre");
            {
                builder.AddAttribute(20001, "class", "output");
            }
            builder.CloseElement();
        }
        builder.CloseElement();

    }

    #endregion

    #region OnAfterRenderAsync

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (firstRender)
        {
            await InvokeJsVoidAsync("MaterialBlazor.MBMenu.setMenuEventListeners", AnchorId, MenuId).ConfigureAwait(false);
        }
    }

    #endregion

}
