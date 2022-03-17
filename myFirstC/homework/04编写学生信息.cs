using System;
using System.Text;
using System.Collections;
struct Student{
    public int id;
    public string name;
    public void Setvalue(String name,int id){
        this.name =name;
        this.id = id;
    }

    public void display(){
        Console.WriteLine("name: {0}",name);
        Console.WriteLine("id: {0}",id);
    }
}

namespace homework{
    class EditStudent{
        static void Main(){
            Student [] students = new Student[5];

            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();
            s1.Setvalue("张飞",3);
            s2.Setvalue("关羽",4);
            s3.Setvalue("刘备",33);
            s4.Setvalue("曹超",44);
            s5.Setvalue("卢布",23);

            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;
            students[4] = s5;
            
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i; j>0&&students[j].id<students[j-1].id; j--)
                {
                    int temp = students[j].id;
                    students[j].id = students[j-1].id;
                    students[j-1].id = temp;
                }
            }

            Console.WriteLine("按学号排序");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].display();
            }


        }
    }

}