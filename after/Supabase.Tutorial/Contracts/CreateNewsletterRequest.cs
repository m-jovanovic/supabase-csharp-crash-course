namespace Supabase.Tutorial.Contracts;

public class CreateNewsletterRequest
{
    public string Name { get; set; }

    public string Description { get; set; }

    public int ReadTime { get; set; }
}