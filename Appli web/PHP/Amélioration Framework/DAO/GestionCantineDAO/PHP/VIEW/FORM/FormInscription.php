<div id="fade">
        <div class="form1">
            <section class="center bgc2 hauteur">
                <form>
                    <div class="titre colSpan2 center">Connexion</div>
                    <div class=" colSpan2 "></div>
                    <div class=" colSpan2 "></div>
                    <label>Adresse mail *</label>
                    <input type="text" name="mail" title="Renseigner l'adresse mail utilisée lors de l'inscription"
                        pattern="^[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+@[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+\.[a-zA-Z]{2,4}$" required>
                    <label>Mot de passe *</label>
                    <input type="password" id="pwd" name="pwd" required
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
                <form>
                    <div class=" bigEspace "></div>
                    <div class=" bigEspace "></div>
                    <div class=" bigEspace "></div>
                    <div class="titre colSpan2 center">Inscription</div>
                    <div class=" colSpan2 "></div>
                    <label>Nom *</label>
                    <input type="text" id="name" name="name" pattern="^[a-zA-ZÀ-ÖØ-öø-ÿ'\-]*$" required
                        title="Renseigner votre nom d'usage">
                    <label>Prenom *</label>
                    <input type="text" id="surname" name="surname" pattern="^[a-zA-ZÀ-ÖØ-öø-ÿ'\-]*$" required
                        title="Renseigner votre prénom">
                    <label>Adresse mail *</label>
                    <input type="text" name="mail"
                        pattern="^[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+@[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+\.[a-zA-Z]{2,4}$" required
                        title="Renseigner une adresse mail valide. Elle sera utilisée pour la connexion">
                        <label>Mot de passe *</label>
                    <input type="password" id="pwd" name="pwd" required
                        title="Renseigner le mot de passe envoyé dans le mail de confirmation"
                        pattern="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$">
                    <label>Téléphone </label>
                    <input type="tel" id="phone" name="phone" pattern="^(0|\+33)[\d]{9}$" required>
                    <div class=" colSpan2 "></div>
                    <input type="reset" value="Reset">
                    <input type="submit" value="Ajouter" disabled>
                </form>
            </section>
        </div>
    </div>