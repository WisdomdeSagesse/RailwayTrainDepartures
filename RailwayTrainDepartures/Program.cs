string[] stationCodes = { "LON", "NOT", "BHM", "MAN", "CDF", "EDB", "GLC", "LDS" };

int[] scheduledHours = { 08, 09, 11, 13, 15, 18, 21, 23 };

int[] scheduledMinutes = { 05, 45, 23, 01, 27, 05, 48, 55 };

int[] lateMinutes = { 8, 0, 37, 6, 0, 0, 20, 9 };

Console.WriteLine("Destination   Scheduled   Expected");

for (int i = 0; i < stationCodes.Length; ++i)
{
    Console.Write("    ");
    Console.Write(stationCodes[i]);
    Console.Write("         ");
    writeTime(scheduledHours[i], scheduledMinutes[i]);
    //Console.Write(scheduledHours[i] + ":" + scheduledMinutes[i]);
    Console.Write("      ");

    int expectedMinutes = scheduledMinutes[i] + lateMinutes[i];
    writeTime(scheduledHours[i], expectedMinutes);
    //Console.Write(scheduledHours[i] + ":" + expectedMinutes);

    Console.WriteLine();
}

void writeTime(int hours, int minutes)
{
    if (minutes >= 60)
    {
        minutes -= 60;
        hours++;
    }
    if(hours >= 24)
    {
        hours -= 24;
    }
    Console.Write($"{hours:00} : {minutes:00}");
}