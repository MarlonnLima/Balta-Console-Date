using System.Globalization;

Console.Clear();
//DateTime date = new DateTime();
var date = DateTime.Now;
//var date = new DateTime(2024, 10, 12, 08, 23, 14);
Console.WriteLine(date);

//var formatted = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", date);
//var formatted = String.Format("{0:t}", date);
//var formatted = String.Format("{0:f}", date);
//var formatted = String.Format("{0:r}", date);
//var formatted = String.Format("{0:s}", date);
var formatted = String.Format("{0:u}", date);

Console.WriteLine(date.AddDays(10));

Console.WriteLine(formatted);

if(date.Date == DateTime.Now.Date) {
    Console.WriteLine("Is equal");
}

var pt = new CultureInfo("pt-PT");
var br = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");
var actual = CultureInfo.CurrentCulture;

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.ToString("D", actual));

var utcDate = DateTime.UtcNow;

Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime());

var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine(timezoneAustralia);

var horaAustralia =
    TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

Console.WriteLine(horaAustralia);


var timezones = TimeZoneInfo.GetSystemTimeZones();

foreach(var timezone in timezones) {
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
    Console.WriteLine("---------------");
}

var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanoSeconds = new TimeSpan(1);
Console.WriteLine(timeSpanNanoSeconds);

var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
Console.WriteLine(timeSpanHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3 , 5, 12, 8);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundoMiliSegundo = new TimeSpan(3 , 5, 12, 8, 30);
Console.WriteLine(timeSpanDiaHoraMinutoSegundoMiliSegundo);

Console.WriteLine(timeSpanDiaHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(5, 0, 0)));
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);