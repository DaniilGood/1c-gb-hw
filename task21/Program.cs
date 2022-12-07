//нахождение катетов
void GetLegs3D(string masseg1, string masseg2, out int leg1, out int leg2, out int leg3)
{
    bool isCorect = false;
    int[] a= new int [9] ;
    int index = 0;
    string[] coor = {"x", "y", "z", "x", "y", "z",};

    while(index<6)
    {
        while(!isCorect)
        {   
            if(index<3)
            {
                Console.Write(masseg1+" "+coor[index]+":");
            }
            else{
                Console.Write(masseg2+" "+coor[index]+":");
            }
            if(int.TryParse(Console.ReadLine(),out a[index]))
            {
                isCorect = true;
            }
            else
            {
                Console.WriteLine("Введенно не число");
            }
        }
        isCorect = false;
        index++;
    }
    
    leg1= Math.Abs(a[0] - a[3]);
    leg2= Math.Abs(a[1] - a[4]);
    leg3= Math.Abs(a[2] - a[5]);
}
//нахождение расстояния
double GetHypotenuses3D(int leg1, int leg2, int leg3)
{
    double hyp = Math.Sqrt(leg1*leg1+leg2*leg2+leg3*leg3);
    return hyp;
}

int leg1, leg2, leg3;
GetLegs3D("Введите для точки А координату","Введите для точки B координату",out leg1,out leg2,out leg3);
Console.WriteLine("Расстояние от точки А до точки В равно: "+GetHypotenuses3D( leg1, leg2, leg3));