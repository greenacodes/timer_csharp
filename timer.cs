using System;
using System.Threading;
class Progarm{
static void Main(){
Console.WriteLine ("Set Minutes for Timer");
int countlimit=60*(Convert.ToInt32(Console.ReadLine()));
int min=0,hr=0;
for(int count=1;count<=countlimit;count++){
for(int sec=0;sec<=60;sec++){
if(sec==60)
{
sec=0;
min++;
}
if(min==60)
{
min=0;
hr++;
}
Console.Clear();
Console.WriteLine(hr+":"+min+":"+sec);
Thread.Sleep(1000);

}
}
}
}
