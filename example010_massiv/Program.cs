int[] array = {5, 12, 13, 41, 56, 16, 75, 41, 18, 96};

int n = array.Length;
int find = 41;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    } 
    //index = index + 1
    index++;
}