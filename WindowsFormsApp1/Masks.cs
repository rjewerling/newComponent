using System.ComponentModel;
using System.Security.Policy;

namespace WindowsFormsApp1 {

    public class Masks {

        private readonly int id;
        private readonly string mask;
        private readonly string description;

        public Masks(int id, string mask, string description) {
            this.id = id;
            this.mask = mask;
            this.description = description;
        }

        public int GetId() { return id; }

        public string GetMask() { return mask; }

        public string GetDescription() { return description; }

        public static Masks FONE {
            get {
                return new Masks(1001, "( __ ) _ ____ - __ - __", "Máscara número telefone ou celular");
            }
        }

        public static Masks CEP => new Masks(1002, "__.___-__", "Máscara de Caixa postal");
        public static Masks RG => new Masks(1003, "__.___.___-_", "Máscara de Registro Geral(Carteira de Identidade)");
        public static Masks CPF => new Masks(1004, "___.___.___-__", "Máscara de Cadastro de Pessoa Física");
        public static Masks PIS => new Masks(1005, string.Empty, string.Empty);
        public static Masks EMAIL => new Masks(1006, string.Empty, string.Empty);
        public static Masks MONETARY => new Masks(1007, string.Empty, string.Empty);
        public static Masks NONE => new Masks(1008, string.Empty, "Nenhuma máscara");
    }
}