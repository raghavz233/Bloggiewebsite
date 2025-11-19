Console.WriteLine("Please input a number");

int userinput = int.Parse(Console.ReadLine());

int StartingNo = 0;

while(StartingNo <= userinput)
{

    Console.WriteLine(StartingNo);
    StartingNo = StartingNo + 2;
}

Console.WriteLine("End");