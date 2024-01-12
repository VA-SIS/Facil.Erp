using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Application.Editions;
using Abp.Application.Features;
using Facil.Erp.Editions;
using System;
using Facil.Erp.EntityFrameworkCore.Entities;

namespace Facil.Erp.EntityFrameworkCore.Seed.Host
{
    public class DefaultPessoasCreator
    {
        private readonly ErpDbContext _context;

        public DefaultPessoasCreator(ErpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreatePessoas();
        }

        private void CreatePessoas()
        {
            var pessoa = new Pessoa("Donisetti","donisetti@msn.com");
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                /* Add desired features to the standard edition, if wanted... */
            }
        }

        private void CreateFeatureIfNotExists(int editionId, string featureName, bool isEnabled)
        {
            if (_context.EditionFeatureSettings.IgnoreQueryFilters().Any(ef => ef.EditionId == editionId && ef.Name == featureName))
            {
                return;
            }

            _context.EditionFeatureSettings.Add(new EditionFeatureSetting
            {
                Name = featureName,
                Value = isEnabled.ToString(),
                EditionId = editionId
            });
            _context.SaveChanges();
        }
    }
}