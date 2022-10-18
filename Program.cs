// Andrea Burr 
// 10-18-2022
// mini Odd or Even redo - github
Console.Clear();

Console.WriteLine("Lets compare odd or even ");
Console.WriteLine("enter your number");

bool playagain = true;

while (playagain){
    

    
string userinput = Console.ReadLine();

int intOne = int.Parse(userinput);
    if (intOne % 2 == 0){
        Console.WriteLine("this is an even number");
        Console.WriteLine(intOne);
    }else{
        Console.WriteLine("this is an odd number");
        Console.WriteLine(intOne);
       

}
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }

}



