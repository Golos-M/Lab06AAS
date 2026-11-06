// Console.WriteLine("Программа запущена.");
// Console.ReadKey();


// Console.WriteLine("Программа запущена.");
// Console.WriteLine("Найдите этот процесс в Диспетчере задач.");
// Console.ReadKey();


// using System.Diagnostics;
// Process currentProcess = Process.GetCurrentProcess();
// Console.WriteLine($"PID: {currentProcess.Id}");
// Console.WriteLine($"Память процесса: {currentProcess.WorkingSet64 / 1024 / 1024} МБ");
// Console.WriteLine("Нажмите Enter для завершения.");
// Console.ReadLine();




using System.Diagnostics;
Process currentProcess = Process.GetCurrentProcess();
Console.WriteLine($"PID: {currentProcess.Id}");
Console.WriteLine("Начинаем вычисления...");
long result = 0;
Stopwatch timer = Stopwatch.StartNew();
while (timer.Elapsed.TotalSeconds < 10) 
{
    for (int i = 0; i < 1_000_000; i++) 
    {
        result += i * i;
    }
}
timer.Stop();
Console.WriteLine($"Результат: {result}");
Console.WriteLine($"Время вычислений: {timer.ElapsedMilliseconds} мс");
Console.WriteLine("Нажмите Enter для завершения.");
Console.ReadLine();