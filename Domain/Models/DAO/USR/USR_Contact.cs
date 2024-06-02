using System.ComponentModel.DataAnnotations;

namespace Domain.Models.DAO.USR;

public class USR_Contact
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    /// <summary>
    /// Url pour du lien contact
    /// </summary>
    /// <remarks>
    /// mailto:** ou https://** ou tel:** ou sms:**
    /// </remarks>
    public string Url { get; set; }
    
    /// <summary>
    /// Icon - Format HTML / SVG
    /// </summary>
    public string? Icon { get; set; }
    public string? Description { get; set; }
}