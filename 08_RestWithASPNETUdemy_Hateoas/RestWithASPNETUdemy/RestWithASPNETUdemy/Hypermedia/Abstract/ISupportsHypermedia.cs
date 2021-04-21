using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermedia.Abstract
{
    public interface ISupportsHypermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
