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

/* 5. ^2
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    arr[i] *= arr[i];
    Console.WriteLine("square: " + arr[i]);
} */

/* 6. ^3 
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    arr[i] *= arr[i] * arr[i];
    Console.WriteLine("3rd power: " + arr[i]);
} */

/* 7. +1
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    arr[i] += 1;
    Console.WriteLine("+1: " + arr[i]);
} */

/* 8. x2
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    arr[i] *= 2;
    Console.WriteLine("x2: " + arr[i]);
} */

/* 9. %2==0
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(arr[i]%2 == 0){
        Console.WriteLine(arr[i]);
    }
} */

/* 10. %2==1
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(arr[i]%2 == 1){
        Console.WriteLine(arr[i]);
    }
} */

/* 11. %3==0
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(arr[i]%3 == 0){
        Console.WriteLine(arr[i]);
    }
} */

/* 12. [4;15>
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(arr[i] >= 4 && arr[i] < 15){
        Console.WriteLine(arr[i]);
    }
} */

/* 13. full odd number
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
string[] arr = new string[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = Console.ReadLine();
}

for(int i=0; i<arr.Length; i++){
    if(arr[i].Contains("1") || arr[i].Contains("3") || arr[i].Contains("5") || arr[i].Contains("7") || arr[i].Contains("9")){
        Console.WriteLine("Has odd");
    } else{
        Console.WriteLine("Full even");
    }
} */




