

public string FizzBuzz(int number)
{
    var answer = "";
    if(number % 3 == 0)
    {
      answer = ($"Fizz");
    }  

    if(number % 5 == 0)
    {
        answer += ($"Buzz");
    }

    return answer;
}
