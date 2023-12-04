using Material.Blazor.Internal;
using Material.Blazor.MenuClose;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

public class MBMenu : ComponentFoundation
{
    #region members

    /// <summary>
    /// The icon on the button used to invoke the menu.
    /// </summary>
    [Parameter] public MBIconDescriptor ButtonIconDescriptor { get; set; }

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
    /// The list of menu items.
    /// </summary>
    [Parameter] public MBMenuItem[] MenuItems { get; set; }

    /// <summary>
    /// Sets the menu positioning attribute
    /// </summary>
    [Parameter] public MBMenuPositioning MenuPositioning { get; set; } = MBMenuPositioning.Relative;



    private string MenuButtonId { get; set; }
    private string MenuId { get; set; }

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        MenuId = "menu-id-" + Guid.NewGuid().ToString().ToLower();
        MenuButtonId = "menu-button-id-" + Guid.NewGuid().ToString().ToLower();

        var attributesToSplat = AttributesToSplat().ToArray();

        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "span");
        {
            builder.AddAttribute(rendSeq++, "class", @ActiveConditionalClasses + @class);
            builder.AddAttribute(rendSeq++, "style", @style + " position: relative; ");
            builder.AddAttribute(rendSeq++, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            builder.OpenComponent(rendSeq++, typeof(MBButton));
            {
                builder.AddComponentParameter(rendSeq++, "Label", ButtonLabel);
                builder.AddComponentParameter(rendSeq++, "ButtonStyle", ButtonStyle);
                builder.AddComponentParameter(rendSeq++, "IconDescriptor", ButtonIconDescriptor);
                builder.AddComponentParameter(rendSeq++, "IconIsTrailing", ButtonIconIsTrailing);
                builder.AddAttribute(rendSeq++, "id", MenuButtonId);
                builder.AddAttribute(rendSeq++, "style", "color: " + ButtonLabelColor + ";");
            }
            builder.CloseComponent();

            builder.OpenElement(rendSeq++, "md-menu");
            {
                builder.AddAttribute(rendSeq++, "anchor", MenuButtonId);
                builder.AddAttribute(rendSeq++, "id", MenuId);
                //builder.AddAttribute(rendSeq++, "onmenuclose", EventCallback.Factory.Create<MenuCloseEventArgs>(this, OnMenuCloseInternal));
                builder.AddAttribute(rendSeq++, "positioning", MenuPositioning.ToString().ToLower());

                if (MenuItems is not null)
                {
                    foreach (var menuItem in MenuItems)
                    {
                        switch (menuItem.MenuItemType)
                        {
                            case MBMenuItemType.BeginSubMenu:
                                break;

                            case MBMenuItemType.Divider:
                                builder.OpenElement(rendSeq++, "md-divider");
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
                                        builder.AddAttribute(rendSeq++, "disabled");
                                    }

                                    if (menuItem.Headline.Length > 0)
                                    {
                                        builder.OpenElement(rendSeq++, "div");
                                        {
                                            if (menuItem.HeadlineColor.Length > 0) 
                                            {
                                                builder.AddAttribute(rendSeq++, "style", "color: " + menuItem.HeadlineColor + "; ");
                                            }
                                            builder.AddAttribute(rendSeq++, "slot", "headline");
                                            builder.AddContent(rendSeq++, menuItem.Headline);
                                        }
                                        builder.CloseElement();

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
                                }
                                builder.CloseComponent();
                                break;
                        }
                    }
                }
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
            await InvokeJsVoidAsync("MaterialBlazor.MBMenu.setToggleMenuOpen", MenuButtonId, MenuId).ConfigureAwait(false);
            await InvokeJsVoidAsync("MaterialBlazor.MBMenu.setMenuCloseEvent", MenuId).ConfigureAwait(false);
        }
    }

    #endregion

    #region OnMenuCloseInternal

    private async Task OnMenuCloseInternal(MenuCloseEventArgs args)
    {
        await Task.CompletedTask;
    }

    #endregion

}
