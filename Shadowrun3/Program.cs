using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowrun3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*
            using (var ctx = new Shadowrun3Context())
            {

                IList<Skill> defaultSkills = new List<Skill>();

                SkillGroup Athletics = new SkillGroup() { SkillGroupId = "Athletics" };
                SkillGroup Biotech = new SkillGroup() { SkillGroupId = "Biotech" };
                SkillGroup CloseCombat = new SkillGroup() { SkillGroupId = "Close Combat" };
                SkillGroup Conjuring = new SkillGroup() { SkillGroupId = "Conjuring" };
                SkillGroup Cracking = new SkillGroup() { SkillGroupId = "Cracking" };
                SkillGroup Electronics = new SkillGroup() { SkillGroupId = "Electronics" };
                SkillGroup Firearms = (new SkillGroup() { SkillGroupId = "Firearms" });
                SkillGroup Influence = (new SkillGroup() { SkillGroupId = "Influence" });
                SkillGroup Mechanic = (new SkillGroup() { SkillGroupId = "Mechanic" });
                SkillGroup Outdoors = (new SkillGroup() { SkillGroupId = "Outdoors" });
                SkillGroup Sorcery = (new SkillGroup() { SkillGroupId = "Sorcery" });
                SkillGroup Stealth = (new SkillGroup() { SkillGroupId = "Stealth" });
                SkillGroup Tasking = (new SkillGroup() { SkillGroupId = "Tasking" });

                defaultSkills.Add(new Skill() { SkillId = "Aeronautics Mechanic", Attribute = "Logic", SkillGroup = Mechanic });
                defaultSkills.Add(new Skill() { SkillId = "Arcana", Attribute = "Logic" });
                defaultSkills.Add(new Skill() { SkillId = "Archery", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Armorer", Attribute = "Logic" });
                defaultSkills.Add(new Skill() { SkillId = "Artisan", Attribute = "Intuition" });
                defaultSkills.Add(new Skill() { SkillId = "Assensing", Attribute = "Intuition" });
                defaultSkills.Add(new Skill() { SkillId = "Astral Combat", Attribute = "Willpower" });
                defaultSkills.Add(new Skill() { SkillId = "Auto Mechanic", Attribute = "Logic", SkillGroup = Mechanic });
                defaultSkills.Add(new Skill() { SkillId = "Automatics", Attribute = "Agility", SkillGroup = Firearms });
                defaultSkills.Add(new Skill() { SkillId = "Banishing", Attribute = "Magic", SkillGroup = Conjuring });
                defaultSkills.Add(new Skill() { SkillId = "Binding", Attribute = "Magic", SkillGroup = Conjuring });
                defaultSkills.Add(new Skill() { SkillId = "Blades", Attribute = "Agility", SkillGroup = CloseCombat });
                defaultSkills.Add(new Skill() { SkillId = "Chemistry", Attribute = "Logic" });
                defaultSkills.Add(new Skill() { SkillId = "Climbing", Attribute = "Strength", SkillGroup = Athletics });
                defaultSkills.Add(new Skill() { SkillId = "Clubs", Attribute = "Agility", SkillGroup = CloseCombat });
                defaultSkills.Add(new Skill() { SkillId = "Compiling", Attribute = "Resonance", SkillGroup = Tasking });
                defaultSkills.Add(new Skill() { SkillId = "Computer", Attribute = "Logic", SkillGroup = Electronics });
                defaultSkills.Add(new Skill() { SkillId = "Con", Attribute = "Charisma", SkillGroup = Influence });
                defaultSkills.Add(new Skill() { SkillId = "Counterspelling", Attribute = "Magic", SkillGroup = Sorcery });
                defaultSkills.Add(new Skill() { SkillId = "Cybercombat", Attribute = "Logic", SkillGroup = Cracking });
                defaultSkills.Add(new Skill() { SkillId = "Cybertechnology", Attribute = "Logic", SkillGroup = Biotech });
                defaultSkills.Add(new Skill() { SkillId = "Data Search", Attribute = "Logic", SkillGroup = Electronics });
                defaultSkills.Add(new Skill() { SkillId = "Decompiling", Attribute = "Resonance", SkillGroup = Tasking });
                defaultSkills.Add(new Skill() { SkillId = "Demolitions", Attribute = "Logic" });
                defaultSkills.Add(new Skill() { SkillId = "Disguise", Attribute = "Intuition", SkillGroup = Stealth });
                defaultSkills.Add(new Skill() { SkillId = "Diving", Attribute = "Body" });
                defaultSkills.Add(new Skill() { SkillId = "Dodge", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Electronic Warfare", Attribute = "Logic", SkillGroup = Cracking });
                defaultSkills.Add(new Skill() { SkillId = "Enchanting", Attribute = "Magic" });
                defaultSkills.Add(new Skill() { SkillId = "Escape Artist", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Etiquette", Attribute = "Charisma", SkillGroup = Influence });
                defaultSkills.Add(new Skill() { SkillId = "Exotic Melee Weapon", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Exotic Ranged Weapon", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "First Aid", Attribute = "Logic", SkillGroup = Biotech });
                defaultSkills.Add(new Skill() { SkillId = "Forgery", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Gunnery", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Gymnastics", Attribute = "Agility", SkillGroup = Athletics });
                defaultSkills.Add(new Skill() { SkillId = "Hacking", Attribute = "Logic", SkillGroup = Cracking });
                defaultSkills.Add(new Skill() { SkillId = "Hardware", Attribute = "Logic", SkillGroup = Electronics });
                defaultSkills.Add(new Skill() { SkillId = "Heavy Weapons", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Industrial Mechanic", Attribute = "Logic", SkillGroup = Mechanic });
                defaultSkills.Add(new Skill() { SkillId = "Infiltration", Attribute = "Agility", SkillGroup = Stealth });
                defaultSkills.Add(new Skill() { SkillId = "Instruction", Attribute = "Charisma" });
                defaultSkills.Add(new Skill() { SkillId = "Intimidation", Attribute = "Charisma" });
                defaultSkills.Add(new Skill() { SkillId = "Leadership", Attribute = "Charisma", SkillGroup = Influence });
                defaultSkills.Add(new Skill() { SkillId = "Locksmith", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Medicine", Attribute = "Logic", SkillGroup = Biotech });
                defaultSkills.Add(new Skill() { SkillId = "Nautical Mechanic", Attribute = "Logic", SkillGroup = Mechanic });
                defaultSkills.Add(new Skill() { SkillId = "Navigation", Attribute = "Intuition", SkillGroup = Outdoors });
                defaultSkills.Add(new Skill() { SkillId = "Negotiation", Attribute = "Charisma", SkillGroup = Influence });
                defaultSkills.Add(new Skill() { SkillId = "Palming", Attribute = "Agility", SkillGroup = Stealth });
                defaultSkills.Add(new Skill() { SkillId = "Parachuting", Attribute = "Body" });
                defaultSkills.Add(new Skill() { SkillId = "Perception", Attribute = "Intuition" });
                defaultSkills.Add(new Skill() { SkillId = "Pilot Aerospace", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Pilot Aircraft", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Pilot Anthroform", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Pilot Exotic Vehicle", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Pilot Ground Craft", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Pilot Watercraft", Attribute = "Reaction" });
                defaultSkills.Add(new Skill() { SkillId = "Pistols", Attribute = "Agility", SkillGroup = Firearms });
                defaultSkills.Add(new Skill() { SkillId = "Registering", Attribute = "Resonance", SkillGroup = Tasking });
                defaultSkills.Add(new Skill() { SkillId = "Ritual Spellcasting", Attribute = "Magic", SkillGroup = Sorcery });
                defaultSkills.Add(new Skill() { SkillId = "Running", Attribute = "Strength", SkillGroup = Athletics });
                defaultSkills.Add(new Skill() { SkillId = "Shadowing", Attribute = "Intuition", SkillGroup = Stealth });
                defaultSkills.Add(new Skill() { SkillId = "Software", Attribute = "Logic", SkillGroup = Electronics });
                defaultSkills.Add(new Skill() { SkillId = "Spellcasting", Attribute = "Magic", SkillGroup = Sorcery });
                defaultSkills.Add(new Skill() { SkillId = "Summoning", Attribute = "Magic", SkillGroup = Conjuring });
                defaultSkills.Add(new Skill() { SkillId = "Survival", Attribute = "Willpower", SkillGroup = Outdoors });
                defaultSkills.Add(new Skill() { SkillId = "Swimming", Attribute = "Strength", SkillGroup = Athletics });
                defaultSkills.Add(new Skill() { SkillId = "Thrown Weapons", Attribute = "Agility" });
                defaultSkills.Add(new Skill() { SkillId = "Tracking", Attribute = "Intuition", SkillGroup = Outdoors });
                defaultSkills.Add(new Skill() { SkillId = "Unarmed Combat", Attribute = "Agility", SkillGroup = CloseCombat });

                ctx.Skills.AddRange(defaultSkills);
                ctx.SaveChanges();
            }*/

        }
    }
}
