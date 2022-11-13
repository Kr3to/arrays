// arrays 

/* 1. max value
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int max = arr[0];

for(int i=1; i<arr.Length; i++){
    if(arr[i] > max){
        max = arr[i];
    }
}

Console.WriteLine("Max value: " + max); */

/* 2. min value
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int min = arr[0];

for(int i=1; i<arr.Length; i++){
    if(arr[i] < min){
        min = arr[i];
    }
}

Console.WriteLine("Min value: " + min); */

/* 3. max value + count 
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int max = arr[0];
int count = 1;

for(int i=1; i<arr.Length; i++){
    if(arr[i] > max){
        max = arr[i];
        count = 1;
    } else if(arr[i] == max){
        count++;
    }
}

Console.WriteLine("Max value: " + max);
Console.WriteLine("Repeated: " + count + " times"); */

/* 4. min value + count 
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int min = arr[0];
int count = 1;

for(int i=1; i<arr.Length; i++){
    if(arr[i] < min){
        min = arr[i];
        count = 1;
    } else if(arr[i] == min){
        count++;
    }
}

Console.WriteLine("Min value: " + min);
Console.WriteLine("Repeated: " + count + " times"); */

/* 5. second max value
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int max = arr[0];
int second = 0;

for(int i=1; i<arr.Length; i++){
    if(arr[i] > max){
        second = max;
        max = arr[i];
    } 
}

Console.WriteLine("Second max value: " + second); */

/* 6. second min value
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int min = arr[0];
int second = 0;

for(int i=1; i<arr.Length; i++){
    if(arr[i] < min){
        second = min;
        min = arr[i];
    } 
}

Console.WriteLine("Second min value: " + second); */


