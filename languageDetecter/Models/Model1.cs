using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace languageDetecter
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<A> A { get; set; }
        public virtual DbSet<B> B { get; set; }
        public virtual DbSet<C> C { get; set; }
        public virtual DbSet<Ç> Ç { get; set; }
        public virtual DbSet<D> D { get; set; }
        public virtual DbSet<E> E { get; set; }
        public virtual DbSet<F> F { get; set; }
        public virtual DbSet<G> G { get; set; }
        public virtual DbSet<Ğ> Ğ { get; set; }
        public virtual DbSet<H> H { get; set; }
        public virtual DbSet<I> I { get; set; }
        public virtual DbSet<İ> İ { get; set; }
        public virtual DbSet<J> J { get; set; }
        public virtual DbSet<K> K { get; set; }
        public virtual DbSet<L> L { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<M> M { get; set; }
        public virtual DbSet<N> N { get; set; }
        public virtual DbSet<O> O { get; set; }
        public virtual DbSet<Ö> Ö { get; set; }
        public virtual DbSet<P> P { get; set; }
        public virtual DbSet<R> R { get; set; }
        public virtual DbSet<S> S { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ş> Ş { get; set; }
        public virtual DbSet<T> T { get; set; }
        public virtual DbSet<U> U { get; set; }
        public virtual DbSet<Ü> Ü { get; set; }
        public virtual DbSet<V> V { get; set; }
        public virtual DbSet<Y> Y { get; set; }
        public virtual DbSet<Z> Z { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
