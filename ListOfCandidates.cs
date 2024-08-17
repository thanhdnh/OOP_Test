using System.Collections;

public class ListOfCandidates{
    public static Candidate[] listofcandidates;
    public ListOfCandidates(Candidate[] input){
        listofcandidates = input;
    }
    public ArrayList search(string kw){
        ArrayList result = new ArrayList();
        foreach(Candidate c in listofcandidates)
            if(c.Fullname.IndexOf(kw)>=0)
                result.Add(c);
        return result;
    }
}