using CrossShop.bl;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace CrossShop
{
    public class MyApp : Application
    {
        public MyApp()
        {
            var assembly = typeof(MyApp).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }


            // The root page of your application
            MainPage = new LoginPage();
            Resources = new ResourceDictionary();
            Resources.Add("ForePrimaryColor", Color.Black);
            Resources.Add("BackPrimaryColor", Color.White);
            Resources.Add("ForeH1Color", Color.FromHex("#505050"));
            Resources.Add("ForeHighLightColor", Color.FromHex("#BA0000"));

            Style stlDefaultLabelStyle = new Style(typeof(Label));
            stlDefaultLabelStyle.ApplyToDerivedTypes = true;

            Setter StlblDftTextColor = new Setter();

            StlblDftTextColor.Property = Label.TextColorProperty;
            StlblDftTextColor.Value = Application.Current.Resources["ForePrimaryColor"];
            stlDefaultLabelStyle.Setters.Add(StlblDftTextColor);

            Setter StlblDfTextSize = new Setter();
            StlblDfTextSize.Property = Label.FontSizeProperty;
            StlblDfTextSize.Value = 13;
            stlDefaultLabelStyle.Setters.Add(StlblDfTextSize);

            Style stlDefaultPageStyle = new Style(typeof(TemplatedPage));
            stlDefaultPageStyle.ApplyToDerivedTypes = true;

            Setter sttDfPageBackColor = new Setter();
            sttDfPageBackColor.Property = TemplatedPage.BackgroundColorProperty;
            sttDfPageBackColor.Value = Application.Current.Resources["BackPrimaryColor"];
            //stlDefaultPageStyle.Setters.Add(sttDfPageBackColor);

            Style stlh1LabelStyle = new Style(typeof(Label));
            stlh1LabelStyle.ApplyToDerivedTypes = true;

            Setter sttForeColorH1label = new Setter();
            sttForeColorH1label.Property = Label.TextColorProperty;
            sttForeColorH1label.Value = Application.Current.Resources["ForeH1Color"];
            stlh1LabelStyle.Setters.Add(sttForeColorH1label);

            Setter SttTxtSizeLabelH1 = new Setter();
            SttTxtSizeLabelH1.Property = Label.FontSizeProperty;
            SttTxtSizeLabelH1.Value = 15;
            stlh1LabelStyle.Setters.Add(SttTxtSizeLabelH1);

            Setter sttTxtFontAtt = new Setter();
            sttTxtFontAtt.Property = Label.FontAttributesProperty;
            sttTxtFontAtt.Value = FontAttributes.Bold;
            stlh1LabelStyle.Setters.Add(sttTxtFontAtt);

            Style stlLabelHighLight = new Style(typeof(Label));
            stlLabelHighLight.ApplyToDerivedTypes = true;

            Setter sttForeColoHighLightLbl = new Setter();
            sttForeColoHighLightLbl.Property = Label.TextColorProperty;
            sttForeColoHighLightLbl.Value = Application.Current.Resources["ForeHighLightColor"];
            stlLabelHighLight.Setters.Add(sttForeColoHighLightLbl);

            Setter sttTxtSizeLabelHighLight = new Setter();
            sttTxtSizeLabelHighLight.Property = Label.FontSizeProperty;
            sttTxtSizeLabelHighLight.Value = 13;
            stlLabelHighLight.Setters.Add(sttTxtSizeLabelHighLight);

            Setter sttTxtFontAttHighLight = new Setter();
            sttTxtFontAttHighLight.Property = Label.FontAttributesProperty;
            sttTxtFontAttHighLight.Value = FontAttributes.Bold;
            stlLabelHighLight.Setters.Add(sttTxtFontAttHighLight);



            Resources.Add(stlDefaultPageStyle);
            Resources.Add(stlDefaultLabelStyle);
            Resources.Add("stlLabelH1", stlh1LabelStyle);
            Resources.Add("stlLabelHighLight", stlLabelHighLight);


        }

        protected override void OnStart()
        {
            ICultureManager ICM = DependencyService.Get<ICultureManager>();
            ICM.CurrentCulture = new CultureInfo("pt-br");
            ICM.CurrentUICulture = new CultureInfo("pt-br");
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");
            //CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt-br");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {

            // Handle when your app resumes
        }

    }
}
