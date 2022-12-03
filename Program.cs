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

/* second max value test
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

int max = arr[0];

for(int i=0; i<arr.Length; i++){
    if(arr[i] > max){
        max = arr[i];
    }
} 

int second = 0;

for(int i=0; i<arr.Length; i++){
    if(arr[i] < max && arr[i] > second){
        second = arr[i];
    }
} 

Console.WriteLine("max " + max);
Console.WriteLine("second " + second); */

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

/* 14. even +100
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(arr[i]%2 == 0){
        arr[i] = arr[i] + 100;
    }
    Console.WriteLine(arr[i]);
} */

/* 15. odd 0
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(arr[i]%2 == 1){
        arr[i] = 0;
    }
    Console.WriteLine(arr[i]);
} */

/* 16. even index
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=0; i<arr.Length; i++){
    if(i%2==0){
        Console.WriteLine(arr[i]);
    }
} */

/* 17. squared index
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=1; i<=x; i++){
    Console.WriteLine(i + " item: ");
    arr[i-1] = int.Parse(Console.ReadLine());
}

for(int i=1; i<arr.Length; i++){
    i = i*i;
    if(arr[i] != null){
        Console.WriteLine(arr[i]);
    }
} */

/* 18. erastotenes
int[] arr = new int[100];

for(int i=0; i< arr.Length; i++){
    arr[i] = i;
}

for(int j=2; j< arr.Length; j++){
    if(arr[j] == 2 || arr[j] == 3 || arr[j] == 5 || arr[j] == 7){
        Console.WriteLine(arr[j] + " ");
    }
    else if(arr[j]%2 != 0 && arr[j]%3 != 0 && arr[j]%5 != 0 && arr[j]%7 != 0){
        Console.WriteLine(arr[j] + " ");
    } 
} */

/* 19. fibon 
int a = 1;
int b = 1;
int c;

for(int i=0; i < 10; i++){
    c = a+b;
    a = b;
    b = c;
    Console.WriteLine(c + " ");
} */

/*
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];

for(int i=0; i<x; i++){
    arr[i] = i;
    Console.WriteLine("index: " + i + " value " + arr[i]);
} */

/*
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];
int j;

for(int i=0; i<x; i++){
    j = i+7;
    arr[i] = j;
    Console.WriteLine("index: " + i + " value " + arr[i]);
} */

/*
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];
int j;

for(int i=0; i<x; i++){
    j = 4;
    if(i == 0){
        arr[i] = j;
    } else{
        arr[i] = j * i + 4;
    }
    Console.WriteLine("index: " + i + " value " + arr[i]);
} */

/*
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];
arr[0] = 1;
Console.WriteLine("index: " + 0 + " value " + arr[0]);

for(int i=1; i<x; i++){
    arr[i] = arr[i - 1] * 2;
    Console.WriteLine("index: " + i + " value " + arr[i]);
} */

/*
Console.WriteLine("Array length: ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];
int j;

for(int i=0; i<x; i++){
    j = i + 2;
    arr[i] = j;
    Console.WriteLine("index: " + i + " value " + arr[i]);
} */

string[] lines = System.IO.File.ReadAllLines(@"C:\Users\xxkre\OneDrive\Pulpit\pesel.txt");
int grudzien = 0;
int kobiet = 0;

int[] arr = new int[100];

for(int i=0; i<100; i++){
    arr[i] = 0;
}


foreach (string line in lines)
{
/* if(line[2] == '1' && line[3] == '2'){
    grudzien = grudzien + 1;
}
if(line[9]%2 == 0){
    kobiet = kobiet + 1;
} */

string year = line.Substring(0, 2);
int yr = int.Parse(year);
arr[yr] = arr[yr] + 1;

}

for(int i=0; i<100; i++){
    Console.WriteLine(arr[i]);
}

// Console.WriteLine("z grudnia osob " + grudzien);
// Console.WriteLine("kobiet " + kobiet);



