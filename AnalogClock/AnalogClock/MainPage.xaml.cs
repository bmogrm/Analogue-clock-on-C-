using Java.Security.Spec;

namespace AnalogClock;

public partial class MainPage : ContentPage
{
	bool ClockTimer()
	{
        DateTime dataTime = DateTime.Now;
        second.RelRotateTo(6);
        int m = dataTime.Minute;
        int s = dataTime.Second;
        if (s == 0)
        {
            minute.RelRotateTo(6);
        }
        if(m == 0)
        {
            hour.RelRotateTo(30);
        }
        return true;
	}


	public MainPage()
	{
		InitializeComponent();

        DateTime dataTime = DateTime.Now;
        int h = (dataTime.Hour + 5) * 30;
        int m = (dataTime.Minute) * 6;
        int s = (dataTime.Second) * 6;

        hour.RotateTo(h);
        minute.RotateTo(m);
        second.RotateTo(s);

        Device.StartTimer(TimeSpan.FromSeconds(1), ClockTimer);
	}

}

