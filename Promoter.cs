using System;

public abstract class Promoter{
    private string _firstName;
    private string _lastName;
    private long _contactNo;

    public string BusinessCard{
        get{
            return String.Format("{0}{1}{2}", this._firstName, this._lastName, this._contactNo);
        }
    }
    public Promoter(string firstName, string lastName, long contactNo){
        this._firstName=firstName;
        this._lastName=lastName;
        this._contactNo=contactNo;
    }

    public void Promote(){
        this.ShareWithInnerCircle();
        this.UsePaidAds();
    }
    abstract protected void ShareWithInnerCircle();
    abstract protected void UsePaidAds();
}