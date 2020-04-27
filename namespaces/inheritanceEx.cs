using System;
namespace inheritanceExample{

public class Branch{
   int branchCode = 101;
   string branchName ="BLR";
    public void DisplayBranchcode(){
        Console.WriteLine(branchCode);
        Console.WriteLine(branchName);
    }
}

public class employee: Branch{
    int empCode = 10;
    String empName= "XYZ";
        public void Displayempcode(){
        Console.WriteLine(empCode);
        Console.WriteLine(empName);
    }
}

 public class driver{
     public static void main(String[] args){
         employee e =new employee();
         e.Displayempcode();
     }
 }
}
