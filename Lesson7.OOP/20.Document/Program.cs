Title title = new Title();
title.Content = "Muqavile";

Body body = new Body();
body.Content = "Muqavilenin esas hissesi...";

Footer footer = new Footer();
footer.Content = "Direktor: Mark";

Document document = new Document(title, body, footer);
document.Show();