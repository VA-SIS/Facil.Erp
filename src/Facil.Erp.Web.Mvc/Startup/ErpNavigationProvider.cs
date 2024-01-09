using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using Facil.Erp.Authorization;

namespace Facil.Erp.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class ErpNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
               
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fas fa-home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "fas fa-building",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "fa-solid fa-user",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "fas fa-theater-masks",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Tasks,
                        new FixedLocalizableString("Tasks"),
                        url: "Tasks",
                        icon: "fas fa-calendar-check"
                        //permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tasks)
                    )
                )
                  .AddItem(
                    new MenuItemDefinition(
                        PageNames.People,
                        new FixedLocalizableString("People"),
                        url: "People",
                        icon: "fas fa-users"
                    //permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tasks)
                    )
                )

                .AddItem( // Menu items below is just for demonstration!
                    new MenuItemDefinition(
                        "OperacaoMenu",
                        new FixedLocalizableString("Operações"),
                        icon: "fas fa-circle"
                    )
                    
                    .AddItem(
                        new MenuItemDefinition(
                            "Cadastro",
                            new FixedLocalizableString("Cadastro"),
                            icon: "far fa-circle"
                        ).AddItem(
                            new MenuItemDefinition(
                                "Pessoas",
                                new FixedLocalizableString("Pessoas"),
                                url: "People",
                                icon: "far fa-dot-circle"
                                 //permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Pessoas)
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "Servicos",
                                new FixedLocalizableString("Serviços"),
                                url: "Servicos",
                                icon: "far fa-dot-circle"
                                  //permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Servicos)
                            )
                        )
                    )
                    
                    .AddItem(
                        new MenuItemDefinition(
                            "Agendamento",
                            new FixedLocalizableString("Agendamento"),
                            icon: "far fa-circle"
                        ).AddItem(
                            new MenuItemDefinition(
                                "Atividades",
                                new FixedLocalizableString("Atividades"),
                                url: "Tasks",
                                icon: "far fa-dot-circle"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "Agenda",
                                new FixedLocalizableString("Agenda"),
                                url: "Agenda",
                                icon: "far fa-dot-circle"
                            )
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ErpConsts.LocalizationSourceName);
        }
    }
}