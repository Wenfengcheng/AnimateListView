using AnimateListView.iOS;
using System;
using UIKit;
using System.Collections.Generic;
using MJRefresh;
using AnimateListView.Shared;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AnimationListView), typeof(AnimateListViewRenderer))]
namespace AnimateListView.iOS
{
    public class AnimateListViewRenderer : ListViewRenderer
    {

        public static void Initialize()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var list = Element as AnimationListView;
                var tableViewController = ((UITableViewController)ViewController);
                
                // add custom color view
                if (list.EnableRefresh)
                {
                    UIView view = new UIView()
                    {
                        BackgroundColor = list.HeaderColor.ToUIColor()
                    };
                    view.Frame = new CoreGraphics.CGRect(0, -tableViewController.TableView.Bounds.Height, tableViewController.TableView.Bounds.Width, tableViewController.TableView.Bounds.Height);

                    tableViewController.TableView.Add(view);
                }

                // custom origin refresh control color
                if (tableViewController.RefreshControl != null)
                {
                    Console.WriteLine("---------done-------------");
                    tableViewController.RefreshControl.TintColor = list.RefreshControlColor.ToUIColor();
                    tableViewController.View.BringSubviewToFront(((UITableViewController)ViewController).RefreshControl);
                }

                // add MJRefresh
                if(list.EnableRefresh)
                {
                    MJRefreshNormalHeader header = new MJRefreshNormalHeader();
                    tableViewController.TableView.SetHeader(header);
                    header.RefreshingBlock = () =>
                    {
                        list.RefreshCommand.Execute(null);
                        header.EndRefreshing();
                    };

                    MJRefreshAutoNormalFooter footer = new MJRefreshAutoNormalFooter();
                    //footer.Hidden = true;
                    tableViewController.TableView.SetFooter(footer);
                    footer.RefreshingBlock = () =>
                    {
                        list.LoadMoreCommand.Execute(null);
                        footer.EndRefreshing();
                    };

                    header.LastUpdatedTimeLabel.TextColor = list.HeaderTintColor.ToUIColor();
                    header.StateLabel.TextColor = list.HeaderTintColor.ToUIColor();
                    header.ArrowView.TintColor = list.HeaderTintColor.ToUIColor();

                    footer.StateLabel.TextColor = list.HeaderTintColor.ToUIColor();

                    tableViewController.TableView.BringSubviewToFront(header);
                    tableViewController.TableView.BringSubviewToFront(footer);
                }
            }
        }
    }
}
