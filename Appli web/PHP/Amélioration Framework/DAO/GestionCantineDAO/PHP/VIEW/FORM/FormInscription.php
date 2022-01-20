<div id="fade">
        <div class="form1">
            <section class="center bgc2 hauteur">
                <form action="index.php?page=actionConnection" method="POST">
                    <div class="titre colSpan2 center">Connexion</div>
                    <div class=" colSpan2 "></div>
                    <div class=" colSpan2 "></div>
                    <label for="emailUser">Adresse mail *</label>
                    <input type="text" name="emailUser" title="Renseigner l'adresse mail utilisée lors de l'inscription"
                        pattern="^[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+@[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+\.[a-zA-Z]{2,4}$" required>
                    <label for="MDPUser">Mot de passe *</label>
                    <input type="password" name="MDPUser" required
                        title="Renseigner le mot de passe envoyé dans le mail de confirmation"
                        pattern="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$">
                    <div class=" colSpan2 "></div>
                    <div class=" colSpan2 "></div>
                    <div class=" colSpan2 "></div>
                    <input type="reset" value="Reset">
                    <input type="submit" value="Connexion" disabled>
                    <div class=" bigEspace "></div>
                    <div class=" bigEspace "></div>
                    <div class=" bigEspace "></div>
                </form>
            </section>
        </div>
        <div></div>
        <div class="form2">
            <section class="center bgc2 hauteur">
                <form action="index.php?page=actionInscription" method="POST">
                    <div class=" bigEspace "></div>
                    <div class=" bigEspace "></div>
                    <div class=" bigEspace "></div>
                    <div class="titre colSpan2 center">Inscription</div>
                    <div class=" colSpan2 "></div>
                    <label for="nom">Nom *</label>
                    <input type="text" id="name" name="name" pattern="^[a-zA-ZÀ-ÖØ-öø-ÿ'\-]*$" required
                        title="Renseigner votre nom d'usage">
                    <label for="prenom">Prenom *</label>
                    <input type="text" id="surname" name="prenom" pattern="^[a-zA-ZÀ-ÖØ-öø-ÿ'\-]*$" required
                        title="Renseigner votre prénom">
                    <label for="emailUser">Adresse mail *</label>
                    <input type="text" name="emailUser"
                        pattern="^[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+@[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+\.[a-zA-Z]{2,4}$" required
                        title="Renseigner une adresse mail valide. Elle sera utilisée pour la connexion">
                        <label for="MDPUser">Mot de passe *</label>
                    <input type="password" name="MDPUser" required
                        title="Renseigner le mot de passe envoyé dans le mail de confirmation"
                        pattern="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$">
                    <div class=" colSpan2 "></div>
                    <input type="reset" value="Reset">
                    <input type="submit" value="Ajouter" disabled>
                </form>
            </section>
        </div>
    </div>