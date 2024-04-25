internal class Program
{
    public static List<Member> GetMaleMembers(List<Member> Members)
    //Create the GetMaleMembers Method - return a List
    {
        List<Member> maleMembers = new List<Member>();
        foreach (Member member in Members)
        {
            if (member.Gender == 'M')
            {
                maleMembers.Add(member);
            }
        }
        
        //Print the list 
        foreach (Member maleMember in maleMembers)
        {
            Console.WriteLine(maleMember);
        }
        return maleMembers;
    }
    
    public static Member GetOldestMember(List<Member> Members)
    //Create the GetOldestMember Method - return a member object

    {
            Member oldestMember = Members[0];
            //Bubble sort --> Oldest member
            foreach (Member member in Members)
            {
                if (member.Age > oldestMember.Age)
                {
                    oldestMember = member;
                }
            }
            return oldestMember;         
    }

    public static List<string> GetFullName(List<Member> Members)
    //Create the GetFullName Method - return a List
    {
        List<string> FullNames = new List<string>();
        foreach (Member member in Members)
        {
            //Add the full name to the list
            FullNames.Add(member.FirstName + " " + member.LastName);
        }
        return FullNames;
    }

    public static List<Member> GetMembers2k(List <Member> Members)
    //Create the GetMembers2k Method - return a List
    {
        List<Member> Members2k = new List<Member>();
        foreach (Member member in Members)
        //Add the member to the list if they were born in 2000 - DOB Year == 2000
        {
            if (member.DOB.Year == 2000)
            {
                Members2k.Add(member);
            }
        }
        return Members2k;
    }
    public static List<Member> GetMembersBefore2k(List <Member> Members)
    //Create the GetMembersBefore2k Method - return a List
    {
        List<Member> MembersBefore2k = new List<Member>();
        foreach (Member member in Members)
        //Add the member to the list if they were born in 2000 - DOB Year < 2000
        {
            if (member.DOB.Year < 2000)
            {
                MembersBefore2k.Add(member);
            }
        }
        return MembersBefore2k;
    }
    
    public static List<Member> GetMembersAfter2k(List <Member> Members)
    //Create the GetMembersAfter2k Method - return a List
    {
        List<Member> MembersAfter2k = new List<Member>();
        foreach (Member member in Members)
        //Add the member to the list if they were born after 2000 - DOB Year > 2000
        {
            if (member.DOB.Year > 2000)
            {
                MembersAfter2k.Add(member);
            }
        }
        return MembersAfter2k;
    }

    public static Member? GetHanoiMembers(List<Member> Members)
    {
        foreach (Member member in Members)
        {
            if (member.BirthPlace == "Ha Noi")
            {
                return member;
            }
        }
        return null; // Add a default return value if no member from Hanoi is found
    }

    public static void Main(string[] args)
    {
        List<Member> Members = new List<Member>{
        new("A", "A", 'M', new DateOnly(2000, 12, 1), "123", "Hai Phong", 24, true),
        new("B", "B", 'F', new DateOnly(2001, 12, 2), "234", "Hue", 24, true),
        new("C", "C", 'M', new DateOnly(2002, 12, 3), "345", "Da Nang", 22, true),
        new("D", "D", 'M', new DateOnly(2003, 12, 4), "456", "Ha Noi", 21, false),
        new("E", "E", 'F', new DateOnly(2001, 12, 5), "567", "Quy Nhon", 23, true),
        new("F", "F", 'F', new DateOnly(2002, 12, 6), "678", "Ha Noi", 22, false),
        new("G", "G", 'M', new DateOnly(1999, 12, 7), "789", "Bac Ninh", 25, true),
        new("H", "H", 'M', new DateOnly(2000, 12, 8), "890", "Nam Dinh", 24, true),
        new("I", "I", 'F', new DateOnly(2004, 12, 9), "901", "Ha Noi", 20, false),
        new("I", "I", 'F', new DateOnly(2003, 12, 10), "012", "Quang Ninh", 21, true)
        };   

        //Menu
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Get male members");
        Console.WriteLine("2. Get the oldest member");
        Console.WriteLine("3. Get a fullname list of all members");
        Console.WriteLine("4. Get lists of all members who were born in 2000, before 2000, and after 2000");
        Console.WriteLine("5. Get a member from Ha Noi");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                GetMaleMembers(Members);
                break;
            case 2:
                Member oldestMember = GetOldestMember(Members);
                Console.WriteLine("The oldest member is: " + oldestMember);
                break;
            case 3:
                List<string> FullNames = GetFullName(Members);
                foreach (string FullName in FullNames)
                {
                    Console.WriteLine(FullName);
                }
                break;
            case 4:
                List<Member> Members2k = GetMembers2k(Members);
                List<Member> MembersBefore2k = GetMembersBefore2k(Members);
                List<Member> MembersAfter2k = GetMembersAfter2k(Members);
                Console.WriteLine("Members who were born in 2000: ");
                foreach (Member member in Members2k)
                {
                    Console.WriteLine(member);
                }

                Console.WriteLine("Members who were born before 2000: ");
                foreach (Member member in MembersBefore2k)
                {
                    Console.WriteLine(member);
                }

                Console.WriteLine("Members who were born after 2000: ");
                foreach (Member member in MembersAfter2k)
                {
                    Console.WriteLine(member);
                }
                break;
            case 5:
                Member memberFromHanoi = GetHanoiMembers(Members);
                if (memberFromHanoi != null)
                {
                    Console.WriteLine("Member from Ha Noi: " + memberFromHanoi);
                }
                else
                {
                    Console.WriteLine("No member from Ha Noi");
                }
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}

