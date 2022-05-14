//2 друга и собака

int count = 0;
int distance = 10000;
int firstfriendSpeed = 1;
int secondfriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 1;

while(distance > 10)

{
    if (friend == 1)
    {
        time = distance / (firstfriendSpeed + dogSpeed);
        friend = 2;
    }

    else if (friend != 1) 
    {
                     time = distance / (secondfriendSpeed + dogSpeed);
        friend = 1;
    }



    distance = distance - (firstfriendSpeed + secondfriendSpeed) * time;

    count++;
}

Console.Write("Собака пробежит : " + count + "раз");

