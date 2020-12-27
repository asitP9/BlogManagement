using System;

public class BlogWriter:Writer{

    public BlogWriter(string firstName, string lastName):base(firstName, lastName){

    }
    public override void Write(){
        Console.WriteLine("I write for my own Blog");
    }

    public override void Vlog(){
        Console.WriteLine("I Vlog using my GoPro");
    }
}