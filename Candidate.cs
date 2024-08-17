public class Candidate
{
    public Candidate(string fullname, float points, bool gender)
    {
        Fullname = fullname;
        Points = points;
        Gender = gender;
    }
    public string ShowInfo(){
        return $"Candidate({Fullname}, {Points}, {Gender})";
    }
    public string Fullname { get; set; }
    public float Points { get; set; }
    public bool Gender { get; set; }
}